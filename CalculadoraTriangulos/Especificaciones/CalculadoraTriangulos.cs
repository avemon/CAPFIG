using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalculadoraTriangulos.Acciones;
using CalculadoraTriangulos.Validaciones;

namespace CalculadoraTriangulos.Especificaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculadoraTriangulos : ICalculadoraTriangulos
    {

        public double Ejecutar(bool calcularArea, double lado1, double lado2, double lado3)
        {
            

            // Validar desigualdad triangular
            ValidarDesigualdadTriangular validadorDeDesigualdadTriangular = new ValidarDesigualdadTriangular();
            if (validadorDeDesigualdadTriangular.Ejecutar(lado1, lado2, lado3))
            {
                ValidarLongitudDeLados validadorLongitudDeLados = new ValidarLongitudDeLados();;
                if (validadorLongitudDeLados.Ejecutar(lado1, lado2, lado3))
                {
                    if (calcularArea)
                    {
                        // Calcular el area del triangulo
                        CalcularArea accion = new CalcularArea();
                        double resultado = accion.Ejecutar(lado1, lado2, lado3);
                        return resultado;
                    }
                    else
                    {
                        // Calcular el perimetro del triangulo
                        CalcularPerimetro accion = new CalcularPerimetro();
                        double resultado = accion.Ejecutar(lado1, lado2, lado3);
                        return resultado;
                    }
                }
                else
                {
                    Console.WriteLine("El triangulo debe tener lados mayores que 0.");
                }
            }
            else
            {
                Console.WriteLine("El triangulo no puede existir con estas medidas para los lados.");
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
