using Gestion_Gym.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Gestion_Gym.Servicios.Persistencia
{
    public class PersonalDAO : DAO<Personal>
    {
        public PersonalDAO() : base() { }

        public override int Editar(Personal Entidad)
        {
            Eliminar(Entidad.Cuil);

            return Guardar(Entidad);
        }

        public override int Eliminar(string cuil)
        {
                int idPersona = 0;
                string sql1 = "SELECT * FROM personal WHERE cuil = @cuil;";
                string sql2 = "DELETE FROM Personal WHERE cuil = @cuil;";
                string sql3 = "DELETE FROM Persona WHERE id_persona = @id_persona;";

                Command.Parameters.AddWithValue("@cuil", cuil); 

                //Obtengo el ID de la persona que coincida con el cuil
                Command.CommandText = sql1;
                using (MySqlDataReader Lector = Command.ExecuteReader())
                {
                    if (Lector.Read())
                    {
                        idPersona = (int)Lector["id_persona"];
                    }
                }

                //Elimino el registro de la tabla persona y de la tabla personal 
                Command.CommandText = sql2;
                CommitNonQuery();

            Command.CommandText = sql3;
            Command.Parameters.AddWithValue("@id_persona", idPersona);

            return CommitNonQuery();
        }

        public override int Guardar(Personal Entidad)
        {
            int id_persona, estado;
            string sql1 = 
                "INSERT INTO Persona(nombre, apellido, f_nacim,f_inicio,email,direccion,genero,telefono)" +
                "VALUES(@nombre, @apellido, @f_nacim,@f_inicio,@email,@direccion,@genero,@telefono);";
            string sql2 =
                "SELECT max(id_persona) as 'id_persona' FROM Persona;";
            string sql3 =
                "INSERT INTO Personal(cuil, id_persona)" +
                "VALUES(@cuil,@id_persona);";

            Command.Parameters.AddWithValue("@nombre", Entidad.Nombre);
            Command.Parameters.AddWithValue("@apellido", Entidad.Apellido);
            Command.Parameters.AddWithValue("@genero", Entidad.Genero);
            Command.Parameters.AddWithValue("@f_nacim", Entidad.FNacimiento);
            Command.Parameters.AddWithValue("@telefono", Entidad.Telefono);
            Command.Parameters.AddWithValue("@email", Entidad.Email);
            Command.Parameters.AddWithValue("@f_inicio", Entidad.FIngreso);
            Command.Parameters.AddWithValue("@direccion", Entidad.Direccion);
            Command.Parameters.AddWithValue("@cuil", Entidad.Cuil);


            Command.CommandText = sql1;
            estado = Command.ExecuteNonQuery();
            Command.CommandText = sql2;

            using (MySqlDataReader lector = Command.ExecuteReader()) 
            {
                if (lector.Read()) 
                {
                    id_persona = Convert.ToInt32(lector["id_persona"]);
                    Command.Parameters.AddWithValue("@id_persona", id_persona);
                }
            }

            Command.CommandText = sql3;
            estado = CommitNonQuery();

            return estado;

        }

        public override Personal Traer(string cuil)
        {

            Personal Buscado = null;

            string sql = 
                "select * from Persona p " +
                "inner join Personal ps " +
                "on p.id_persona = ps.id_persona " +
                "WHERE ps.cuil = @cuil;";

            Command.CommandText = sql;
            Command.Parameters.AddWithValue("@cuil", cuil);

            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                if (Lector.Read())
                {
                    Buscado = new Personal(
                         Lector["nombre"].ToString(),
                         Lector["apellido"].ToString(),
                         Lector["cuil"].ToString(),
                         Lector["f_nacim"].ToString(),
                         Convert.ToChar(Lector["genero"]),
                         Lector["telefono"].ToString(),
                         Lector["email"].ToString(),
                         Lector["direccion"].ToString(),
                         Lector["f_inicio"].ToString()
                    );
                }
                Command.Parameters.Clear();

                return Buscado;
            }
        }

        public override List<Personal> TraerTodos()
        {
            List<Personal> Miembros = new List<Personal>();

            string sql = "select * from Persona p inner join Personal ps on p.id_persona = ps.id_persona ;";
            Command.CommandText = sql;

            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                while (Lector.Read())
                {
                    Miembros.Add(new Personal(
                         Lector["nombre"].ToString(),
                         Lector["apellido"].ToString(),
                         Lector["cuil"].ToString(),
                         Lector["f_nacim"].ToString(),
                         Convert.ToChar(Lector["genero"]),
                         Lector["telefono"].ToString(),
                         Lector["email"].ToString(),
                         Lector["direccion"].ToString(),
                         Lector["f_inicio"].ToString()
                    ));
                }
                Command.Parameters.Clear();

                return Miembros;

            }
        }

        public bool VerificarCredenciales(string Usuario, string Contrasenia)
        {
            string sql = "SELECT count(nombre) as resultado FROM usuario WHERE nombre = @nombre AND contrasenia = @contrasenia";
            Command.CommandText = sql;
            Command.Parameters.Clear();

            Command.Parameters.AddWithValue("@nombre", Usuario);
            Command.Parameters.AddWithValue("@contrasenia", Contrasenia);


            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                if (Lector.Read())
                {
                    if (Convert.ToInt32(Lector["resultado"]) > 0)
                    {
                        return true;
                    }
                }
            }
            Command.Parameters.Clear();

            return false;
        }
    }
}
