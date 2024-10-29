using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Gestion_Gym.Servicios;
using FluentAssertions.Primitives;
using FluentAssertions;

namespace GestionGYMTests
{
    /// <summary>
    /// Descripción resumida de prueba
    /// </summary>
    [TestClass]
    public class ValidacionTests
    {
        
        public ValidacionTests()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        [TestMethod]
        public void ValidarEmail()
        {
            BooleanAssertions.ReferenceEquals(Validacion.ValidarEmail("ejemplo@gmail.com"), true);
            Validacion.ValidarEmail("otroEjemplo@gmail.com").Should().BeTrue();
            Validacion.ValidarEmail("122fewfsdfs").Should().BeFalse();
        }

        [TestMethod]
        public void ValidarTelefono()
        {
            Validacion.ValidarCelular("3813960697").Should().BeTrue();
            Validacion.ValidarCelular("124326gd").Should().BeFalse();
        }

        [TestMethod]
        public void ValidarCuil()
        {
            Validacion.ValidarCuil("20-44617444-5").Should().BeTrue();
            Validacion.ValidarCuil("27446174449").Should().BeTrue();
            Validacion.ValidarCuil("-3434232.6").Should().BeFalse();
            Validacion.ValidarCuil("34sad334232").Should().BeFalse();
        }

        [TestMethod]
        public void ValidarDocumento()
        {

            Validacion.ValidarDocumento("25844933").Should().BeTrue();
            Validacion.ValidarDocumento("44617444").Should().BeTrue();
            Validacion.ValidarDocumento("20-44617444-5").Should().BeFalse();
            Validacion.ValidarDocumento("-3434232.6").Should().BeFalse();
            Validacion.ValidarDocumento("34sad334232").Should().BeFalse();
        }

        [TestMethod]
        public void ValidarTexto()
        {
            Validacion.ValidarCadenaEstandar("abcdefghijk").Should().BeTrue();
            Validacion.ValidarCadenaEstandar("-3434232").Should().BeFalse();
            Validacion.ValidarCadenaEstandar("34sad334dsf232").Should().BeFalse();
            Validacion.ValidarCadenaEstandar("diaz43").Should().BeFalse();
            Validacion.ValidarCadenaEstandar("matias muro").Should().BeTrue();
        }

        [TestMethod]
        public void ValidarFechas()
        {
            Validacion.ValidarFecha("17/01/2003").Should().BeTrue();
            Validacion.ValidarFecha("17/1/03").Should().BeTrue();
            Validacion.ValidarFecha("17103").Should().BeFalse();
            Validacion.ValidarFecha("-3434232").Should().BeFalse();
            Validacion.ValidarFecha("34sad334dsf232").Should().BeFalse();
        }
        [TestMethod]
        public void ValidarTodo()
        {
            Validacion.ValidarCadenaEstandar("Paola").Should().BeTrue();
            Validacion.ValidarCadenaEstandar("Diaz").Should().BeTrue(); 
            Validacion.ValidarDocumento("25844933").Should().BeTrue(); 
            Validacion.ValidarFecha("25/06/1977").Should().BeTrue(); 
            Validacion.ValidarCelular("3813960697").Should().BeTrue(); 
            Validacion.ValidarEmail("Correo@gmail.com").Should().BeTrue(); 
            Validacion.ValidarFecha("16/10/2024").Should().BeTrue(); 
            Validacion.ValidarCadenaEstandar("Direccion de ejemplo").Should().BeTrue();
  
        }
    }
}
