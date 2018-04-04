﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionParcial
{
    [TestClass]
    public class Linea3DTests
    {
        [TestMethod]
        public void TestLongitud()
        {
            Punto3D[] puntos = new Punto3D[] { new Punto3D(0, 0, 0), new Punto3D(0, 3, 0), new Punto3D(0, 6, 0) };
            Linea3D linea3D = new Linea3D(puntos);
            Assert.AreEqual(6, linea3D.Longitud());
        }

        [TestMethod]
        public void TestPuntoMasCercano()
        {
            Punto3D[] puntos = new Punto3D[] { new Punto3D(0, 0, 0), new Punto3D(0, 3, 0), new Punto3D(0, 6, 0) };
            Linea3D linea3D = new Linea3D(puntos);
            Assert.AreEqual(puntos[0], linea3D.PuntoMasCercano(new Punto3D(0, 1, 0)));
        }
    }
}
