using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TipoDatoCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 06-Tipo de dato carácter.");

            char primeraLetra = 'A';
            char letraComoNumero = (char)65;

            letraComoNumero = (char)(letraComoNumero + 1);
            Console.WriteLine("La primera letra es:" + primeraLetra);
            Console.WriteLine("El numero 66 representa la letra:" + letraComoNumero);

            Console.ReadLine();
        }
    }
}
