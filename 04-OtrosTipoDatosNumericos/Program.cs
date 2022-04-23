using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OtrosTipoDatosNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 04-Otros Tipos de Datos Numéricos.");

            byte cantidadLetras = 28;

            Console.WriteLine("Cantidad de letras: " + cantidadLetras);

            short cantidadPaises = 1000;

            Console.WriteLine("Cantidad de letras: " + cantidadPaises);

            int cantidadEspecies = 1000000000;

            Console.WriteLine("Cantidad de especies: " + cantidadEspecies);

            long unNumeroMuyGrande = 1000000000000000000;

            Console.WriteLine("Un número muy grande: " + unNumeroMuyGrande);

            float decimalPequeno = 100.01f;

            Console.WriteLine("Decimal pequeño: " + decimalPequeno);

            double salario = 12435.345;

            Console.WriteLine("Salario: " + salario);

            decimal decimalGrande = 8982982989898392.23m;

            Console.WriteLine("Decimal grande: " + decimalGrande);




            Console.ReadLine();
        }
    }
}
