using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ConversionTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 05-Conversión Tipos de Datos Numéricos.");

            byte cantidadLetras = 28;

            Console.WriteLine("Cantidad de letras: " + cantidadLetras);

            short cantidadPaises = 1000;

            Console.WriteLine("Cantidad de letras: " + cantidadPaises);

            

            

            float decimalPequeno = 100.01f;

            Console.WriteLine("Decimal pequeño: " + decimalPequeno);

            double salario = 12435.345;

            Console.WriteLine("Salario: " + salario);

            int salarioEnEnteros = (int)salario;

            Console.WriteLine("Salario en Enteros: " + salarioEnEnteros);


            decimal decimalGrande = 8982982989898392.23m;

            Console.WriteLine("Decimal grande: " + decimalGrande);

            long unNumeroMuyGrande = (long)decimalGrande;

            Console.WriteLine("Un número muy grande: " + unNumeroMuyGrande);



            Console.ReadLine();
        }
    }
}
