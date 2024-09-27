using FluentAssertions;
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
        private Personal m2 = new Personal("Leo", "juarez", "20-44617444-5", "21/03/2002", 'M', "43123542", "ejemploemail@hotmail.com", "Direccion de leo", "26/06/2022");

        [TestMethod]
        public void Guardar()
        {
            PersonalDAO.Guardar(m1);

            Personal aux = PersonalDAO.Traer(m1.Cuil);


            aux.Should().BeEquivalentTo(m1);
        }

        [TestMethod]
        public void Editar()
        {
            PersonalDAO.Editar(m2);
            Personal aux = PersonalDAO.Traer(m2.Cuil);

            aux.Should().BeEquivalentTo(m2);
            //Assert.IsInstanceOfType(aux, typeof(Personal));
            
        }

        [TestMethod]
        public void Traer()
        {
            Personal buscado = PersonalDAO.Traer(m1.Cuil);

            buscado.Should().NotBeNull();
        }

        [TestMethod]
        public void Eliminar()
        {
            int estado = PersonalDAO.Eliminar(m2.Cuil);
            
            estado.Should().BeGreaterThan(0);
            
            //Assert.AreEqual(estado.GetType(), aux.GetType());
        }

    }
}
