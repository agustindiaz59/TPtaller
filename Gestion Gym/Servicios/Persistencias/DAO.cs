using Gestion_Gym.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Gestion_Gym.Servicios.Persistencia
{
    public abstract class DAO<T> where T : class//T es el tipo de dato a persistir en la BBDD
    {

        protected MySqlConnection Connection;
        protected MySqlCommand Command;

        public DAO()
        {
            try
            {
                Connection = new MySqlConnection(
                "server=localhost;" +
                "port=3306;" +
                "database=gymbd;" +
                "user=root;" +
                "password=admin;"
            );
                Connection.Open();
                Command = Connection.CreateCommand();

                Console.WriteLine("Conexion a base de datos establecida");
            }catch (Exception ex)
            {
                Console.WriteLine("Error en la conexion a la base de datos");
                throw ex;
            }
        }

        public abstract int Guardar(T Entidad);
        public abstract int Editar(T Entidad);
        public abstract int Eliminar(string dni);
        public abstract T Traer(string dni);
        public abstract List<T> TraerTodos();
        public int CommitNonQuery()
        {
            int estado = Command.ExecuteNonQuery();
            Command.Parameters.Clear();

            return estado;
        }

    }
}
