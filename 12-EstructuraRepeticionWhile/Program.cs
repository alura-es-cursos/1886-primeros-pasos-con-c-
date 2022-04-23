using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EstructuraRepeticionWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 12-Estructura de Repetición Mientras.");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.
            int iNumMes = 1;

            //mientras que(condición)
            while(iNumMes <= 12) 
            { 
                //saldo = saldo + saldo * interes;
                saldo += saldo * interes;
                Console.WriteLine("El saldo luego del "+iNumMes+" mes es: " + saldo);
               //iNumMes = iNumMes + 1;
                iNumMes++;
                //iNumMes += 1;

            }
            
            Console.ReadLine();
        }
    }
}
