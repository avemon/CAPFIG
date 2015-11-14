using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCuadrilateros.Acciones
{
    class CalcularAreaTrapecio
    {

        public double Ejecutar(double baseSuperior, double baseInferior, double altura)
        {
            return altura * (baseSuperior + baseInferior) / 2.0;
        }

    }
}
