using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EstructuraRepiticionPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 13-Estructura de Repetición Para.");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.

            //valor de partida;condición de finalización;valor de avance
            for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
            {
                //saldo = saldo + saldo * interes;
                saldo += saldo * interes;
                Console.WriteLine("El saldo luego del " + iNumMes + " mes es: " + saldo);
                //iNumMes = iNumMes + 1;
                //iNumMes += 1;

            }

            Console.ReadLine();
        }
    }
}
