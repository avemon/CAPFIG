using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCuadrilateros.Acciones
{
    class CalcularPerimetroTrapecio
    {

        public double Ejecutar(double baseSuperior, double baseInferior, double altura)
        {
            // Si se trata de un trapecio irregular, se requieren cuatro valores
            // Pero el programa solamente recibe tres
            // Se asume que el trapecio es regular, y el valor de altura es el valor de las diagonales
            return baseSuperior + baseInferior + altura * 2;
        }

    }
}
