using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTriangulos.Acciones
{
    class CalcularArea
    {
        public double Ejecutar(double lado1, double lado2, double lado3)
        {
            double s = (lado1 + lado2 + lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }
    }
}
