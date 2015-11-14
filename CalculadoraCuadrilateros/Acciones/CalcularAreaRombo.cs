using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCuadrilateros.Acciones
{
    class CalcularAreaRombo
    {

        public double Ejecutar(double diagonalMayor, double diagonalMenor)
        {
            return (diagonalMayor * diagonalMenor) / 2.0;
        }

    }
}
