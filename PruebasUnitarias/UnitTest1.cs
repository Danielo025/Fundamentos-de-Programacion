using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ex03_VentasBarrioOriginal;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalizaGalletasBarrio()
        {
            //Arrange
            string[] arregloBarrios = { "Manrique", "Moravia", "Poblado", "Laureles", "Aranjuez" };
            Pedido[] arregloPedidos = new Pedido[5];

            Pedido pedidos = new Pedido();
            pedidos.Barrio = "Manrique";
            pedidos.CantidadGalletas = 24;
            pedidos.Barrio = "Aranjuez";
            pedidos.CantidadGalletas = 24;
            pedidos.Barrio = "Laureles";
            pedidos.CantidadGalletas = 51;
            pedidos.Barrio = "Poblado";
            pedidos.CantidadGalletas = 5;
            pedidos.Barrio = "Moravia";
            pedidos.CantidadGalletas = 21;

            //Act

            string[] galletasBarrio = arregloBarrios;
            Program.TotalizaGalletasBarrio(arregloPedidos, galletasBarrio);

            Pedido cantidadEsperada = new Pedido();
            cantidadEsperada.Barrio = "Manrique";
            cantidadEsperada.CantidadGalletas = 24;

            //Assert
            Assert.AreEqual(cantidadEsperada, galletasBarrio);

        }
    }
}
