using Gestion_Gym.Modelos;
using Gestion_Gym.Servicios.Persistencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GestionGYMTests
{
    [TestClass]
    public class PersonalDAOTests
    {
        private PersonalDAO PersonalDAO = new PersonalDAO();
        private Personal m1 = new Personal("Matias", "Muro", "20-44617444-5", "17/01/2003", 'M', "3813960697", "matutias@gmail.com", "direccion de ejemplo", "22/05/2024");
        private Personal m2 = new Personal("Leo", "juarez", "20-544617444-5", "21/03/2002", 'M', "43123542", "ejemploemail@hotmail.com", "Direccion de leo", "26/06/2022");

        [TestMethod]
        [Priority(1)]
        public void Guardar()
        {
            int estado = PersonalDAO.Guardar(m1);
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());
        }

        [TestMethod]
        [Priority(2)]
        public void Editar()
        {
            int estado = PersonalDAO.Editar(m2);
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());
        }

        [TestMethod]
        [Priority(3)]
        public void Traer()
        {
            Personal buscado = PersonalDAO.Traer(m1.Cuil);

            Assert.IsNotNull(buscado);
        }

        [TestMethod]
        [Priority(4)]
        public void Eliminar()
        {
            int estado = PersonalDAO.Eliminar(m2.Cuil);
            int aux = 0;

            Assert.AreEqual(estado.GetType(), aux.GetType());
        }

    }
}
