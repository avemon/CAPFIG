using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTriangulos.Validaciones
{
    class ValidarDesigualdadTriangular
    {
        public bool Ejecutar(double lado1, double lado2, double lado3)
        {
            // Para cualquier triángulo la suma de las longitudes de dos lados cualquiera 
            // debe ser siempre mayor a la longitud del lado restante
            // https://es.wikipedia.org/wiki/Desigualdad_triangular

            return (lado1 + lado2 > lado3 &&
                    lado1 + lado3 > lado2 &&
                    lado2 + lado3 > lado1);
        }
    }
}
