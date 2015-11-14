using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPoligonos.Validaciones
{
    class ValidarNumeroDeLados
    {

        public bool Ejecutar(int numeroDeLados)
        {
            return (numeroDeLados >= 5 && numeroDeLados < 16);
        }

    }
}
