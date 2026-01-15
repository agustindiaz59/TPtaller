using Gestion_Gym.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Gym.Servicios.Persistencia
{
    public class PersonalDAO : DAO<Personal>
    {
        public PersonalDAO() : base() { }

        // Editar: actualiza datos de Persona manteniendo el CUIL como clave
        public override int Editar(Personal entidad)
        {
            using (var tx = Connection.BeginTransaction())
            {
                try
                {
                    int idPersona = ObtenerIdPersonaPorCuil(entidad.Cuil, tx);
                    if (idPersona == 0)
                        throw new Exception("No se encontró el personal a editar.");

                    string sqlUpdatePersona =
                        "UPDATE Persona SET nombre=@nombre, apellido=@apellido, f_nacim=@f_nacim, f_inicio=@f_inicio, " +
                        "email=@email, direccion=@direccion, genero=@genero, telefono=@telefono " +
                        "WHERE id_persona=@id_persona;";

                    Command.Parameters.Clear();
                    Command.Transaction = tx;
                    Command.CommandText = sqlUpdatePersona;

                    Command.Parameters.AddWithValue("@nombre", entidad.Nombre);
                    Command.Parameters.AddWithValue("@apellido", entidad.Apellido);
                    Command.Parameters.AddWithValue("@genero", entidad.Genero);
                    Command.Parameters.AddWithValue("@f_nacim", entidad.FNacimiento);
                    Command.Parameters.AddWithValue("@telefono", entidad.Telefono);
                    Command.Parameters.AddWithValue("@email", entidad.Email);
                    Command.Parameters.AddWithValue("@f_inicio", entidad.FIngreso);
                    Command.Parameters.AddWithValue("@direccion", entidad.Direccion);
                    Command.Parameters.AddWithValue("@id_persona", idPersona);

                    int filas = Command.ExecuteNonQuery();
                    tx.Commit();
                    return filas;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public override int Eliminar(string cuil)
        {
            using (var tx = Connection.BeginTransaction())
            {
                try
                {
                    Command.Transaction = tx;
                    int idPersona = ObtenerIdPersonaPorCuil(cuil, tx);
                    if (idPersona == 0)
                        return 0;

                    Command.Parameters.Clear();
                    Command.CommandText = "DELETE FROM Personal WHERE cuil = @cuil;";
                    Command.Parameters.AddWithValue("@cuil", cuil);
                    Command.ExecuteNonQuery();

                    Command.Parameters.Clear();
                    Command.CommandText = "DELETE FROM Persona WHERE id_persona = @id_persona;";
                    Command.Parameters.AddWithValue("@id_persona", idPersona);
                    int filas = Command.ExecuteNonQuery();

                    tx.Commit();
                    return filas;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public override int Guardar(Personal entidad)
        {
            using (var tx = Connection.BeginTransaction())
            {
                try
                {
                    Command.Transaction = tx;

                    // Verificar duplicado CUIL
                    if (ExisteCuil(entidad.Cuil, tx))
                        return 0; // señal de duplicado

                    // Insert Persona
                    Command.Parameters.Clear();
                    Command.CommandText =
                        "INSERT INTO Persona(nombre, apellido, f_nacim, f_inicio, email, direccion, genero, telefono) " +
                        "VALUES(@nombre, @apellido, @f_nacim, @f_inicio, @email, @direccion, @genero, @telefono);";

                    Command.Parameters.AddWithValue("@nombre", entidad.Nombre);
                    Command.Parameters.AddWithValue("@apellido", entidad.Apellido);
                    Command.Parameters.AddWithValue("@genero", entidad.Genero);
                    Command.Parameters.AddWithValue("@f_nacim", entidad.FNacimiento);
                    Command.Parameters.AddWithValue("@telefono", entidad.Telefono);
                    Command.Parameters.AddWithValue("@email", entidad.Email);
                    Command.Parameters.AddWithValue("@f_inicio", entidad.FIngreso);
                    Command.Parameters.AddWithValue("@direccion", entidad.Direccion);

                    Command.ExecuteNonQuery();

                    // Obtener id_persona recién insertado
                    Command.Parameters.Clear();
                    Command.CommandText = "SELECT LAST_INSERT_ID();";
                    int idPersona = Convert.ToInt32(Command.ExecuteScalar());

                    // Insert Personal
                    Command.Parameters.Clear();
                    Command.CommandText = "INSERT INTO Personal(cuil, id_persona) VALUES(@cuil, @id_persona);";
                    Command.Parameters.AddWithValue("@cuil", entidad.Cuil);
                    Command.Parameters.AddWithValue("@id_persona", idPersona);

                    int filas = Command.ExecuteNonQuery();

                    tx.Commit();
                    return filas;
                }
                catch (MySqlException ex)
                {
                    tx.Rollback();
                    if (ex.Number == 1062) return 0; // error de duplicado
                    throw;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public override Personal Traer(string cuil)
        {
            Personal buscado = null;

            Command.Parameters.Clear();
            Command.CommandText =
                "SELECT * FROM Persona p " +
                "INNER JOIN Personal ps ON p.id_persona = ps.id_persona " +
                "WHERE ps.cuil = @cuil;";
            Command.Parameters.AddWithValue("@cuil", cuil);

            using (MySqlDataReader lector = Command.ExecuteReader())
            {
                if (lector.Read())
                {
                    buscado = new Personal(
                        lector["nombre"].ToString(),
                        lector["apellido"].ToString(),
                        lector["cuil"].ToString(),
                        lector["f_nacim"].ToString(),
                        Convert.ToChar(lector["genero"]),
                        lector["telefono"].ToString(),
                        lector["email"].ToString(),
                        lector["direccion"].ToString(),
                        lector["f_inicio"].ToString()
                    );
                }
            }
            Command.Parameters.Clear();
            return buscado;
        }

        public override List<Personal> TraerTodos()
        {
            var lista = new List<Personal>();

            Command.Parameters.Clear();
            Command.CommandText =
                "SELECT * FROM Persona p INNER JOIN Personal ps ON p.id_persona = ps.id_persona;";

            using (MySqlDataReader lector = Command.ExecuteReader())
            {
                while (lector.Read())
                {
                    lista.Add(new Personal(
                        lector["nombre"].ToString(),
                        lector["apellido"].ToString(),
                        lector["cuil"].ToString(),
                        lector["f_nacim"].ToString(),
                        Convert.ToChar(lector["genero"]),
                        lector["telefono"].ToString(),
                        lector["email"].ToString(),
                        lector["direccion"].ToString(),
                        lector["f_inicio"].ToString()
                    ));
                }
            }
            Command.Parameters.Clear();
            return lista;
        }

        // ---------- Helpers privados ----------

        private bool ExisteCuil(string cuil, MySqlTransaction tx)
        {
            Command.Parameters.Clear();
            Command.Transaction = tx;
            Command.CommandText = "SELECT COUNT(*) FROM Personal WHERE cuil = @cuil;";
            Command.Parameters.AddWithValue("@cuil", cuil);

            var result = Command.ExecuteScalar();
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        private int ObtenerIdPersonaPorCuil(string cuil, MySqlTransaction tx)
        {
            Command.Parameters.Clear();
            Command.Transaction = tx;
            Command.CommandText = "SELECT id_persona FROM Personal WHERE cuil = @cuil;";
            Command.Parameters.AddWithValue("@cuil", cuil);

            var result = Command.ExecuteScalar();
            if (result == null || result == DBNull.Value) return 0;
            return Convert.ToInt32(result);
        }

        public bool VerificarCredenciales(string usuario, string contrasenia)
        {
            Command.Parameters.Clear();
            Command.CommandText = "SELECT COUNT(nombre) FROM usuario WHERE nombre = @nombre AND contrasenia = @contrasenia";
            Command.Parameters.AddWithValue("@nombre", usuario);
            Command.Parameters.AddWithValue("@contrasenia", contrasenia);

            var result = Command.ExecuteScalar();
            int count = Convert.ToInt32(result);
            Command.Parameters.Clear();
            return count > 0;
        }
    }
}
