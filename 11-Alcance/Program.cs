using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Alcance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 11-Alcance.");

            //Codigo para determinar si la persona puede entrar al parque
            int edadPersona = 18;
            bool acompanado = false;
            string mensajeAlcance = "";

            if (edadPersona >= 18 && acompanado)
            {
                Console.WriteLine("La persona puede entrar al parque");
                mensajeAlcance = "Condición cumplida;";
            }
            else
            {
                bool empleado = false;
                if (edadPersona < 18)
                {
                    Console.WriteLine("La persona no tiene edad suficiente");
                    mensajeAlcance = "Condición edad no cumplida;";
                }


                Console.WriteLine(empleado);
            }

            Console.WriteLine(mensajeAlcance);


            Console.ReadLine();
        }
    }
}
