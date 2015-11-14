using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPoligonos.Validaciones
{
    class ValidarLongitudDeLados
    {

        public bool Ejecutar(double tamanoPorLado)
        {
            return (tamanoPorLado > 0);
        }

    }
}
