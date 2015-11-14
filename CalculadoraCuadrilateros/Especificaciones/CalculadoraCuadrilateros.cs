using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalculadoraCuadrilateros.Acciones;
using CalculadoraCuadrilateros.Validaciones;

namespace CalculadoraCuadrilateros.Especificaciones
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CalculadoraCuadrilateros : ICalculadoraCuadrilateros
    {

        public double Ejecutar(bool calcularArea, string tipo, double lado1, double lado2, double altura)
        {
            tipo = tipo.ToUpper();

            // Validar el tipo de cuadrilatero
            ValidarTipoDeCuadrilatero validadorDeTipo = new ValidarTipoDeCuadrilatero();
            if (validadorDeTipo.Ejecutar(tipo))
            {
                ValidarLongitudDeLados validadorDeLongitudDeLados = new ValidarLongitudDeLados();
                if (validadorDeLongitudDeLados.Ejecutar(lado1, lado2))
                {
                    ValidarAltura validadorDeAltura = new ValidarAltura();
                    if (validadorDeAltura.Ejecutar(altura))
                    {
                        if (calcularArea)
                        {
                            switch (tipo)
                            {
                                case "PARALELOGRAMO":
                                    {
                                        CalcularAreaParalelogramo accion = new CalcularAreaParalelogramo();
                                        return accion.Ejecutar(lado1, altura);
                                    }
                                case "CUADRADO":
                                    {
                                        CalcularAreaCuadrado accion = new CalcularAreaCuadrado();
                                        return accion.Ejecutar(lado1);
                                    }
                                case "RECTANGULO":
                                    {
                                        CalcularAreaRectangulo accion = new CalcularAreaRectangulo();
                                        return accion.Ejecutar(lado1, altura);
                                    }
                                case "ROMBO":
                                    {
                                        CalcularAreaRombo accion = new CalcularAreaRombo();
                                        return accion.Ejecutar(lado1, lado2);
                                    }
                                case "ROMBOIDE":
                                    {
                                        CalcularAreaRomboide accion = new CalcularAreaRomboide();
                                        return accion.Ejecutar(lado1, altura);
                                    }
                                case "TRAPECIO":
                                    {
                                        CalcularAreaTrapecio accion = new CalcularAreaTrapecio();
                                        return accion.Ejecutar(lado1, lado2, altura);
                                    }
                            }
                        }
                        else
                        {
                            switch (tipo)
                            {
                                case "PARALELOGRAMO":
                                    {
                                        CalcularPerimetroParalelogramo accion = new CalcularPerimetroParalelogramo();
                                        return accion.Ejecutar(lado1, lado2);
                                    }
                                case "CUADRADO":
                                    {
                                        CalcularPerimetroCuadrado accion = new CalcularPerimetroCuadrado();
                                        return accion.Ejecutar(lado1);
                                    }
                                case "RECTANGULO":
                                    {
                                        CalcularPerimetroRectangulo accion = new CalcularPerimetroRectangulo();
                                        return accion.Ejecutar(lado1, lado2);
                                    }
                                case "ROMBO":
                                    {
                                        CalcularPerimetroRombo accion = new CalcularPerimetroRombo();
                                        return accion.Ejecutar(altura);
                                    }
                                case "ROMBOIDE":
                                    {
                                        CalcularPerimetroRomboide accion = new CalcularPerimetroRomboide();
                                        return accion.Ejecutar(lado1, lado2);
                                    }
                                case "TRAPECIO":
                                    {
                                        // Se asume trapecio regular
                                        CalcularPerimetroTrapecio accion = new CalcularPerimetroTrapecio();
                                        return accion.Ejecutar(lado1, lado2, altura);
                                    }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ALTURA DEBE SER MAYOR QUE 0.");
                    }
                }
                else
                {
                    Console.WriteLine("LOS LADOS DEBEN MEDIR MAS QUE 0.");
                }
            }
            else
            {
                Console.WriteLine("TIPO DE CUADRILATERO DESCONOCIDO.");
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
