using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestsPoligono
    {

        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando pruebas para el servicio de poligonos...");
            TestMethod1();
            TestMethod2();
            TestMethod3();
            TestMethod4();
            TestMethod5();
            TestMethod6();
            TestMethod7();
            TestMethod8();
            TestMethod9();
            TestMethod10();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int numeroDeLados = 5;
            double tamanoPorLado = 8;

            double areaEsperada = 110.11;
            double areaObtenida = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            areaObtenida = cliente.Ejecutar(true, numeroDeLados, tamanoPorLado);
            areaObtenida = Math.Round(areaObtenida, 2); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 1 de Poligonos: exitosa... (area de un pentagono)");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int numeroDeLados = 5;
            double tamanoPorLado = 8;

            double perimetroEsperado = 40;
            double perimetroObtenido = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            perimetroObtenido = cliente.Ejecutar(false, numeroDeLados, tamanoPorLado);
            perimetroObtenido = Math.Round(perimetroObtenido, 2); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 2 de Poligonos: exitosa... (perimetro de un pentagono)");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int numeroDeLados = 10;
            double tamanoPorLado = 15;

            double areaEsperada = 1731.2;
            double areaObtenida = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            areaObtenida = cliente.Ejecutar(true, numeroDeLados, tamanoPorLado);
            areaObtenida = Math.Round(areaObtenida, 2); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 3 de Poligonos: exitosa... (area de un decagono)");
        }

        [TestMethod]
        public void TestMethod4()
        {
            int numeroDeLados = 10;
            double tamanoPorLado = 15;

            double perimetroEsperado = 150;
            double perimetroObtenido = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            perimetroObtenido = cliente.Ejecutar(false, numeroDeLados, tamanoPorLado);
            perimetroObtenido = Math.Round(perimetroObtenido, 2); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 4 de Poligonos: exitosa... (perimetro de un decagono)");
        }

        [TestMethod]
        public void TestMethod5()
        {
            int numeroDeLados = 13;
            double tamanoPorLado = 9;

            double areaEsperada = 1068.05;
            double areaObtenida = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            areaObtenida = cliente.Ejecutar(true, numeroDeLados, tamanoPorLado);
            areaObtenida = Math.Round(areaObtenida, 2); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 5 de Poligonos: exitosa... (area de un tridecagono)");
        }

        [TestMethod]
        public void TestMethod6()
        {
            int numeroDeLados = 13;
            double tamanoPorLado = 9;

            double perimetroEsperado = 117;
            double perimetroObtenido = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            perimetroObtenido = cliente.Ejecutar(false, numeroDeLados, tamanoPorLado);
            perimetroObtenido = Math.Round(perimetroObtenido, 2); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 6 de Poligonos: exitosa... (perimetro de un tridecagono)");
        }


        [TestMethod]
        public void TestMethod7()
        {
            int numeroDeLados = 7;
            double tamanoPorLado = 0;

            double areaEsperada = -1; // -1 puesto que no se permiten lados de tamano 0
            double areaObtenida = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            areaObtenida = cliente.Ejecutar(true, numeroDeLados, tamanoPorLado);
            areaObtenida = Math.Round(areaObtenida, 2); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 7 de Poligonos: exitosa... (area de un poligono con lados iguales a 0)");
        }

        [TestMethod]
        public void TestMethod8()
        {
            int numeroDeLados = 13;
            double tamanoPorLado = -5;

            double perimetroEsperado = -1; // -1 puesto que no se permiten lados menores que 0
            double perimetroObtenido = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            perimetroObtenido = cliente.Ejecutar(false, numeroDeLados, tamanoPorLado);
            perimetroObtenido = Math.Round(perimetroObtenido, 2); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 8 de Poligonos: exitosa... (perimetro de un poligono con lados menores a 0)");
        }

        [TestMethod]
        public void TestMethod9()
        {
            int numeroDeLados = 4;
            double tamanoPorLado = 10;

            double areaEsperada = -1; // -1 puesto que no se permiten poligonos con menos de 5 lados
            double areaObtenida = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            areaObtenida = cliente.Ejecutar(true, numeroDeLados, tamanoPorLado);
            areaObtenida = Math.Round(areaObtenida, 2); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 9 de Poligonos: exitosa... (area de un poligono con menos de 5 lados)");
        }

        [TestMethod]
        public void TestMethod10()
        {
            int numeroDeLados = 17;
            double tamanoPorLado = 10;

            double perimetroEsperado = -1; // -1 puesto que no se permiten poligonos con mas de 16 lados
            double perimetroObtenido = 0.0;

            ServicioPoligonos.CalculadoraPoligonosClient cliente = new ServicioPoligonos.CalculadoraPoligonosClient();
            perimetroObtenido = cliente.Ejecutar(false, numeroDeLados, tamanoPorLado);
            perimetroObtenido = Math.Round(perimetroObtenido, 2); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 10 de Poligonos: exitosa... (perimetro de un poligono con mas de 16 lados)");
        }
    }
}
