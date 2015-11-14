using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTriangulos.Validaciones
{
    class ValidarLongitudDeLados
    {

        public bool Ejecutar(double lado1, double lado2, double lado3)
        {
            return (lado1 > 0 && lado2 > 0 && lado3 > 0);
        }

    }
}
