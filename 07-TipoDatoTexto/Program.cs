using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TipoDatoTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 07-Tipo de dato texto.");

            char primeraLetra = '\t';
            char letraComoNumero = (char)65;

            letraComoNumero = (char)(letraComoNumero + 1);

            Console.WriteLine("Col1" + primeraLetra + "Col2" + primeraLetra + "Col3");
            Console.WriteLine("Col1b" + primeraLetra + "Col2b" + primeraLetra + "Col3b");


            string nombreCurso = "Estoy en el curso de:\n"+
            "C# Primeros pasos";
            Console.WriteLine(nombreCurso);


            Console.ReadLine();
        }
    }
}
