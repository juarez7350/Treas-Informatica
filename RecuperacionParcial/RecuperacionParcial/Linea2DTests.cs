﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2;

namespace LineasTest
{
    [TestClass]
    public class Linea2DTests
    {
        [TestMethod]
        public void TestLongitud()
        {
            Punto2D[] puntos = new Punto2D[] { new Punto2D(0, 0), new Punto2D(0, 7), new Punto2D(0, 2) };
            Linea2D linea2D = new Linea2D(puntos);
            Assert.AreEqual(6, linea2D.Longitud());
        }

        [TestMethod]
        public void TestPuntoMasCercano()
        {
            Punto2D[] puntos = new Punto2D[] { new Punto2D(0, 0), new Punto2D(0, 7), new Punto2D(0, 2) };
            Linea2D linea2D = new Linea2D(puntos);
            Assert.AreEqual(puntos[0], linea2D.PuntoMasCercano(new Punto2D(0, 1)));
        }
    }
}
