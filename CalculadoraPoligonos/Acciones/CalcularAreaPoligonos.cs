using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPoligonos.Acciones
{
    class CalcularAreaPoligonos
    {

        public double Ejecutar(int numeroDeLados, double tamanoPorLado)
        {
            // Formula: http://www.wikicalculator.com/formula_calculator/Area-of-regular-polygon-with-n-sides-inscribed-in-a-unit-radius-circle-(given-side-and-angle)-118.htm
            return (Math.Pow(tamanoPorLado, 2)*numeroDeLados)/(4*Math.Tan(Math.PI/numeroDeLados));
        }

    }
}
