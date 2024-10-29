using Gestion_Gym.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Gestion_Gym.Servicios.Persistencia
{
    public class MiembroDAO : DAO<Miembro>
    {
        public MiembroDAO() : base()
        {
        }

        public override int Editar(Miembro Entidad)
        {
            if (Entidad == null)
            {
                return 0;
            }

            Eliminar(Entidad.DNI);

            return Guardar(Entidad);
        }


        public override int Eliminar(string dni)
        {
            if (Traer(dni) != null)
            {
                int idPersona = 0;
                string sql1 = "SELECT * FROM Miembro WHERE dni = @dni;";
                string sql2 = "DELETE FROM Miembro WHERE dni = @dni; DELETE FROM Persona WHERE id_persona = @id_persona;";

                Command.Parameters.AddWithValue("@dni", dni);

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
                Command.Parameters.AddWithValue("@id_persona", idPersona);



                return CommitNonQuery();
            }
            else
                return -1;
        }

        public override int Guardar(Miembro Entidad)
        {
            //string sql = 
            //    "INSERT INTO miembros(nombre, apellido, dni, genero, fnacim, telefono, email, fingreso, direccion, horariogym, tipomembresia)" +
            //    "VALUES (@nombre, @apellido, @dni, @genero, @fnacim, @telefono, @email, @fingreso, @direccion, @horariogym, @tipomembresia);";
            string sql1 = "insert into Persona(nombre, apellido, f_nacim, f_inicio, email, direccion, genero, telefono) values(@nombre,@apellido,@f_nacim,@f_inicio,@email, @direccion,@genero,@telefono);";
            string sql2 = "select max(p.id_persona) from Persona p;";
            string sql3 = "insert into Miembro(dni, horariogym, id_membresia, id_persona) values(@dni,@horariogym,@id_membresia,@id_persona);";
            int idPersona = 1;

            //Cargo los datos del miembro
            Command.Parameters.AddWithValue("@nombre", Entidad.Nombre);
            Command.Parameters.AddWithValue("@apellido", Entidad.Apellido);
            Command.Parameters.AddWithValue("@dni", Entidad.DNI);
            Command.Parameters.AddWithValue("@genero", Entidad.Genero);
            Command.Parameters.AddWithValue("@f_nacim", Entidad.FNacimiento);
            Command.Parameters.AddWithValue("@telefono", Entidad.Telefono);
            Command.Parameters.AddWithValue("@email", Entidad.Email);
            Command.Parameters.AddWithValue("@f_inicio", Entidad.FIngreso);
            Command.Parameters.AddWithValue("@direccion", Entidad.Direccion);
            Command.Parameters.AddWithValue("@horariogym", Entidad.HorarioGYM);
            Command.Parameters.AddWithValue("@id_membresia", Entidad.TipoMembrecia);

            //Agrego una persona
            Command.CommandText = sql1;
            Command.ExecuteNonQuery();

            //Obtengo el ID de la ultima persona agregada
            Command.CommandText = sql2;
            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                if (Lector.Read())
                {
                    idPersona = (int)Lector["max(p.id_persona)"];
                }
            }

            //Agrego el miembro
            Command.CommandText = sql3;
            Command.Parameters.AddWithValue("@id_persona", idPersona);

            int estado = CommitNonQuery();
            if (estado > -1)
            {
                MessageBox.Show("Datos Guardados Correctamente.");
            }
            return estado;
        }

        public override Miembro Traer(string dni)
        {
            Miembro Buscado = null;
            string sql = "select * from Persona p inner join Miembro m on p.id_persona = m.id_persona where m.dni = @dni;";
            Command.Parameters.AddWithValue("@dni", dni);

            Command.CommandText = sql;

            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                if (Lector.Read())
                {
                    Buscado = new Miembro(
                         Lector["nombre"].ToString(),
                         Lector["apellido"].ToString(),
                         Lector["dni"].ToString(),
                         Lector["f_nacim"].ToString(),
                         Convert.ToChar(Lector["genero"]),
                         Lector["telefono"].ToString(),
                         Lector["email"].ToString(),
                         Lector["direccion"].ToString(),
                         Lector["f_inicio"].ToString(),
                         (Membresia)Lector["id_membresia"],
                         Lector["horariogym"].ToString()
                    );
                }
                Command.Parameters.Clear();

                return Buscado;
            }
        }

        public override List<Miembro> TraerTodos()
        {

            List<Miembro> Miembros = new List<Miembro>();

            string sql = "select * from Persona p inner join Miembro m on p.id_persona = m.id_persona ;";
            Command.CommandText = sql;

            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                while (Lector.Read())
                {
                    Miembros.Add(new Miembro(
                         Lector["nombre"].ToString(),
                         Lector["apellido"].ToString(),
                         Lector["dni"].ToString(),
                         Lector["f_nacim"].ToString(),
                         Convert.ToChar(Lector["genero"]),
                         Lector["telefono"].ToString(),
                         Lector["email"].ToString(),
                         Lector["direccion"].ToString(),
                         Lector["f_inicio"].ToString(),
                         (Membresia)Lector["id_membresia"],
                         Lector["horariogym"].ToString()
                    ));
                }
                Command.Parameters.Clear();

                return Miembros;
            }


        }
        public List<Miembro> buscarPorNombre(string Campo) 
        { 
            List<Miembro> todos = TraerTodos();
            List<Miembro> coincidencias = new List<Miembro>();

            foreach (Miembro m in todos) 
            {
                if (m.Nombre.Contains(Campo)) 
                {
                    coincidencias.Add(m);
                }
            }

            return coincidencias;
        }

        public List<Miembro> buscarPorApellido(string Apellido)
        {
            List<Miembro> todos = TraerTodos();
            List<Miembro> coincidencias = new List<Miembro>();

            foreach (Miembro m in todos)
            {
                if (m.Apellido.Contains(Apellido))
                {
                    coincidencias.Add(m);
                }
            }

            return coincidencias;
        }

        public List<Miembro> buscarPorDNI(string DNI)
        {
            List<Miembro> todos = TraerTodos();
            List<Miembro> coincidencias = new List<Miembro>();

            foreach (Miembro m in todos)
            {
                if (m.DNI.Contains(DNI))
                {
                    coincidencias.Add(m);
                }
            }

            return coincidencias;
        }

        public List<Miembro> Select(string sql)
        {
            List<Miembro> Miembros = new List<Miembro>();
            Command.CommandText = sql;

            using (MySqlDataReader Lector = Command.ExecuteReader())
            {
                while (Lector.Read())
                {
                    Miembros.Add(new Miembro(
                         Lector["nombre"].ToString(),
                         Lector["apellido"].ToString(),
                         Lector["dni"].ToString(),
                         Lector["f_nacim"].ToString(),
                         Convert.ToChar(Lector["genero"]),
                         Lector["telefono"].ToString(),
                         Lector["email"].ToString(),
                         Lector["direccion"].ToString(),
                         Lector["f_inicio"].ToString(),
                         (Membresia)Lector["id_membresia"],
                         Lector["horariogym"].ToString()
                    ));
                }
                Command.Parameters.Clear();

                return Miembros;
            }
        }
    }
}
