using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCuadrilateros.Validaciones
{
    class ValidarLongitudDeLados
    {

        public bool Ejecutar(double lado1, double lado2)
        {
            return (lado1 > 0 && lado2 > 0);
        }

    }
}
