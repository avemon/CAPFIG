using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalculadoraPoligonos.Acciones;
using CalculadoraPoligonos.Validaciones;

namespace CalculadoraPoligonos.Especificaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculadoraPoligonos : ICalculadoraPoligonos
    {
        public double Ejecutar(bool calcularArea, int numeroDeLados, double tamanoPorLado)
        {
            ValidarNumeroDeLados validadorNumeroDeLados = new ValidarNumeroDeLados();
            if (validadorNumeroDeLados.Ejecutar(numeroDeLados))
            {
                ValidarLongitudDeLados validadorLongitudDeLados = new ValidarLongitudDeLados();
                if (validadorLongitudDeLados.Ejecutar(tamanoPorLado))
                {
                    if (calcularArea)
                    {
                        CalcularAreaPoligonos accion = new CalcularAreaPoligonos();
                        return accion.Ejecutar(numeroDeLados, tamanoPorLado);
                    }
                    else
                    {
                        CalcularPerimetroPoligonos accion = new CalcularPerimetroPoligonos();
                        return accion.Ejecutar(numeroDeLados, tamanoPorLado);
                    }
                }
                else
                {
                    Console.WriteLine("El tamano de los lados debe ser mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Numero de lados debe ser mayor que 4 y menor que 17.");
            }
            return -1;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
