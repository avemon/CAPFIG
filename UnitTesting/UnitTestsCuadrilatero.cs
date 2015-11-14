using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestsCuadrilatero
    {

        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando pruebas para el servicio de cuadrilateros...");
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
            TestMethod11();
            TestMethod12();
            TestMethod13();
            TestMethod14();
            TestMethod15();
            TestMethod16();
        }

        [TestMethod]
        public void TestMethod1()
        {
            double lado1 = 10;
            double lado2 = 10;
            double altura = 10;
            string tipo = "CUADRADO";

            double areaEsperada = 100;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 1 de Cuadrilateros: exitosa... (area de un cuadrado)");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double lado1 = 10;
            double lado2 = 3;
            double altura = 3;
            string tipo = "CUADRADO";

            double areaEsperada = 100; // Se espera un area de 100 puesto que el cuadrado solo va a usar el primer valor
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 2 de Cuadrilateros: exitosa... (area de un cuadrado)");
        }

        [TestMethod]
        public void TestMethod3()
        {
            double lado1 = 0;
            double lado2 = 0;
            double altura = 0;
            string tipo = "CUADRADO";

            double areaEsperada = -1; // Lados iguales o menores a 0 causan un error (-1)
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 3 de Cuadrilateros: exitosa... (lados iguales a 0)");
        }

        [TestMethod]
        public void TestMethod4()
        {
            double lado1 = 8;
            double lado2 = 8;
            double altura = 8;
            string tipo = "CUADRADO";

            double perimetroEsperado = 32;
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 4 de Cuadrilateros: exitosa... (perimetro de un cuadrado)");
        }


        [TestMethod]
        public void TestMethod5()
        {
            double lado1 = 15;
            double lado2 = 6;
            double altura = 10;
            string tipo = "PARALELOGRAMO";

            double areaEsperada = 150;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 5 de Cuadrilateros: exitosa... (area de un paralelogramo)");
        }


        [TestMethod]
        public void TestMethod6()
        {
            double lado1 = 15;
            double lado2 = 6;
            double altura = 6;
            string tipo = "PARALELOGRAMO";

            double perimetroEsperado = 42;
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 6 de Cuadrilateros: exitosa... (perimetro de un paralelogramo)");
        }


        [TestMethod]
        public void TestMethod7()
        {
            double lado1 = 100;
            double lado2 = 20;
            double altura = 20;
            string tipo = "RECTANGULO";

            double areaEsperada = 2000;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 7 de Cuadrilateros: exitosa... (area de un rectangulo)");
        }


        [TestMethod]
        public void TestMethod8()
        {
            double lado1 = 100;
            double lado2 = 20;
            double altura = 20;
            string tipo = "RECTANGULO";

            double perimetroEsperado = 240;
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 8 de Cuadrilateros: exitosa... (perimetro de un rectangulo)");
        }

        [TestMethod]
        public void TestMethod9()
        {
            double lado1 = 50;
            double lado2 = 30;
            double altura = 15;
            string tipo = "ROMBO";

            double areaEsperada = 750;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 9 de Cuadrilateros: exitosa... (area de un rombo)");
        }


        [TestMethod]
        public void TestMethod10()
        {
            double lado1 = 50;
            double lado2 = 30;
            double altura = 15;
            string tipo = "ROMBO";

            double perimetroEsperado = 60;
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 10 de Cuadrilateros: exitosa... (perimetro de un rombo)");
        }

        [TestMethod]
        public void TestMethod11()
        {
            double lado1 = 20;
            double lado2 = 15;
            double altura = 10;
            string tipo = "ROMBOIDE";

            double areaEsperada = 200;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 11 de Cuadrilateros: exitosa... (area de un romboide)");
        }


        [TestMethod]
        public void TestMethod12()
        {
            double lado1 = 20;
            double lado2 = 15;
            double altura = 10;
            string tipo = "ROMBOIDE";

            double perimetroEsperado = 70;
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 12 de Cuadrilateros: exitosa... (perimetro de un romboide)");
        }

        [TestMethod]
        public void TestMethod13()
        {
            double lado1 = 30;
            double lado2 = 50;
            double altura = 10;
            string tipo = "TRAPECIO";

            double areaEsperada = 400;
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 13 de Cuadrilateros: exitosa... (area de un trapecio)");
        }


        [TestMethod]
        public void TestMethod14()
        {
            double lado1 = 30;
            double lado2 = 50;
            double altura = 10;
            string tipo = "TRAPECIO";

            double perimetroEsperado = 100; // Se asume que es un trapecio regular, por lo tanto el perimetro es 30 + 50 + 10 + 10 = 100
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 14 de Cuadrilateros: exitosa... (perimetro de un trapecio)");
        }

        [TestMethod]
        public void TestMethod15()
        {
            double lado1 = 30;
            double lado2 = 50;
            double altura = 10;
            string tipo = "ELIPSE";

            double areaEsperada = -1; // -1 puesto que no existe una ELIPSE en el sistema
            double areaObtenida = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            areaObtenida = cliente.Ejecutar(true, tipo, lado1, lado2, altura);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 15 de Cuadrilateros: exitosa... (area de una figura desconocida)");
        }


        [TestMethod]
        public void TestMethod16()
        {
            double lado1 = 30;
            double lado2 = 50;
            double altura = 10;
            string tipo = "ELIPSE";

            double perimetroEsperado = -1; // -1 puesto que no existe una ELIPSE en el sistema
            double perimetroObtenido = 0;

            ServicioCuadrilateros.CalculadoraCuadrilaterosClient cliente = new ServicioCuadrilateros.CalculadoraCuadrilaterosClient();
            perimetroObtenido = cliente.Ejecutar(false, tipo, lado1, lado2, altura);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 16 de Cuadrilateros: exitosa... (perimetro de una figura desconocida)");
        }

    }
}
