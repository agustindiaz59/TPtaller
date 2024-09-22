using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestion_Gym.Servicios.Persistencia;
using Gestion_Gym.Modelos;
using System;

namespace GestionGYMTests
{
    [TestClass]
    public class MiembroDaoTests
    {

        private MiembroDAO miembroDAO = new MiembroDAO();
        private Miembro m1 = new Miembro("Matias", "Muro", "44617444", "17/01/2003", 'M', "3813960697", "matutias@gmail.com", "direccion de ejemplo", "22/05/2024", (Membresia)2, "19:00 -- 21:00");
        private Miembro m2 = new Miembro("Leo", "juarez", "44617444", "21/03/2002", 'M', "43123542", "ejemploemail@hotmail.com", "Direccion de leo", "26/06/2022", (Membresia)1, "18:00 -- 20:00");
        

        [TestMethod]
        public void Guardar()
        {
            int estado = miembroDAO.Guardar(m1);
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());
        }

        [TestMethod]
        public void Editar()
        {
            int estado = miembroDAO.Editar(m2);
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());

        }

        [TestMethod]
        public void Traer()
        {
            Miembro buscado = miembroDAO.Traer("44617444");

            
            Assert.IsNotNull(buscado);
        }
        [TestMethod]
        public void Eliminar()
        {
            int estado = miembroDAO.Eliminar("44617444");
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());

        }

    }
}
