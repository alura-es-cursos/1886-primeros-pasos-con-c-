using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_VariablesBooleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 10-Variables booleanas.");

            //Codigo para determinar si la persona puede entrar al parque
            int edadPersona = 18;
            bool acompanado = false;

            if (edadPersona >= 18 && acompanado)
            {
                Console.WriteLine("La persona puede entrar al parque");
            }
            else
            {
                if (edadPersona < 18)
                {
                    Console.WriteLine("La persona no tiene edad suficiente");
                } else if (!acompanado)
                {
                    Console.WriteLine("La persona no está acompañada");
                }
                
            }

 
            Console.ReadLine();
        }
    }
}
