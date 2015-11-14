using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestsTriangulo
    {

        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando pruebas para el servicio de triangulos...");
            TestMethod1();
            TestMethod2();
            TestMethod3();
            TestMethod4();
        }

        [TestMethod]
        public void TestMethod1()
        {
            double lado1 = 10;
            double lado2 = 8;
            double lado3 = 7;
            double areaEsperada = 27.81074;
            double areaObtenida = 0.0;

            ServicioTriangulos.CalculadoraTriangulosClient cliente = new ServicioTriangulos.CalculadoraTriangulosClient();
            areaObtenida = cliente.Ejecutar(true, lado1, lado2, lado3);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 1 de Triangulos: exitosa...");
        }

        [TestMethod]
        public void TestMethod2()
        {
            double lado1 = 10;
            double lado2 = 8;
            double lado3 = 7;
            double perimetroEsperado = 25;
            double perimetroObtenido = 0.0;

            ServicioTriangulos.CalculadoraTriangulosClient cliente = new ServicioTriangulos.CalculadoraTriangulosClient();
            perimetroObtenido = cliente.Ejecutar(false, lado1, lado2, lado3);
            perimetroObtenido = Math.Round(perimetroObtenido, 5); // Redondear resultado
            Assert.IsTrue(perimetroObtenido == perimetroEsperado);
            Console.WriteLine("   ... Prueba 2 de Triangulos: exitosa...");
        }

        [TestMethod]
        public void TestMethod3()
        {
            double lado1 = 1000;
            double lado2 = 5;
            double lado3 = 5;
            double areaEsperada = -1; // Se espera un -1 puesto que no existe un triangulo con estas dimensiones
            double areaObtenida = 0;

            ServicioTriangulos.CalculadoraTriangulosClient cliente = new ServicioTriangulos.CalculadoraTriangulosClient();
            areaObtenida = cliente.Ejecutar(false, lado1, lado2, lado3);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 3 de Triangulos: exitosa...");
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            double lado1 = 10;
            double lado2 = 8;
            double lado3 = 0;
            double areaEsperada = -1; // Se espera un -1 puesto que hay un lado que es menor o igual que 0
            double areaObtenida = 0;

            ServicioTriangulos.CalculadoraTriangulosClient cliente = new ServicioTriangulos.CalculadoraTriangulosClient();
            areaObtenida = cliente.Ejecutar(false, lado1, lado2, lado3);
            areaObtenida = Math.Round(areaObtenida, 5); // Redondear resultado
            Assert.IsTrue(areaObtenida == areaEsperada);
            Console.WriteLine("   ... Prueba 4 de Triangulos: exitosa...");
        }
    }
}
