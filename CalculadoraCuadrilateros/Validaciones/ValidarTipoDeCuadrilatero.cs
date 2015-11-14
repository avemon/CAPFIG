using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCuadrilateros.Validaciones
{
    class ValidarTipoDeCuadrilatero
    {
        public bool Ejecutar(string tipo)
        {
            return (tipo.Equals("PARALELOGRAMO") || (tipo.Equals("CUADRADO") || 
                    tipo.Equals("RECTANGULO") || tipo.Equals("ROMBO") ||
                    tipo.Equals("ROMBOIDE") || tipo.Equals("TRAPECIO")));
        }
    }
}
