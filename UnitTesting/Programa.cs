using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    static class Programa
    {

        public static void Main()
        {
            UnitTestsTriangulo testsParaTriangulo = new UnitTestsTriangulo();
            testsParaTriangulo.Ejecutar();

            UnitTestsCuadrilatero testsParaCuadrilatero = new UnitTestsCuadrilatero();
            testsParaCuadrilatero.Ejecutar();

            UnitTestsPoligono testsParaPoligono = new UnitTestsPoligono();
            testsParaPoligono.Ejecutar();

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }

    }
}
