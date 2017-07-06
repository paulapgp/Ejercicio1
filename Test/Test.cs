using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio1;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Operaciones sut = new Operaciones();
            Principal obj = new Principal();
            obj.nombreApellidos = "Paula Garcia Pasalodos";
            obj.edad = 23;
            obj.año = 1994;

            string cadenaReal = sut.CrearMensaje(obj);
            string cadenaEsperada = "La persona seleccionada es : Paula Garcia Pasalodos nacida en el año 1994 y edad 23 años";

            Assert.AreEqual(cadenaReal, cadenaEsperada);
        }
    }
}
