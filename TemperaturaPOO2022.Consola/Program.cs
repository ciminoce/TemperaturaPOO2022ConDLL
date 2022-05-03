using System;
using TemperaturaPOO2022.Entidades;
using MisNuevasFunciones;
namespace TemperaturaPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new[] {"1-Celsius", "2-Fahrenheit"};
            
            Escala escala =(Escala) Mostrar.MostrarMenu(menu);
            double valor =IngresoDatos.PedirDouble("Ingrese el valor de la temperatura:");

            Temperatura temperatura = new Temperatura(escala, valor);

            if (temperatura.Validar())
            {
                Console.WriteLine($"{temperatura.Grados} grados {temperatura.Escala.ToString()} equivalen a {temperatura.GetConversion()}");
            }
            else
            {
                Console.WriteLine("Temperatura no válida");
            }

            Console.ReadLine();
        }


    }
}
