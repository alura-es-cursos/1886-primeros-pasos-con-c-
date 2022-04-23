using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_PalabraReservada_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando el proyecto 14-Estructura de Repetición FOR Anidadas.");

            double saldo = 1000;
            double interes = 0.75 / 100; //0.75% por mes.

            for (int iNumAso = 1; iNumAso <= 5; iNumAso++)
            {
                Console.WriteLine("Año: " + iNumAso);

                if (iNumAso >= 5) // 1632.28869032175
                {
                    interes = 0.90 / 100;
                }
                else if (iNumAso >= 3) // 1324.3175856601
                {
                    interes = 0.85 / 100;
                }


                for (int iNumMes = 1; iNumMes <= 12; iNumMes++)
                {
                   
                    //saldo = saldo + saldo * interes;
                    saldo += saldo * interes;
                    if (saldo > 1500)
                        break;
                    Console.WriteLine("El saldo luego del " + iNumMes + " mes es: " + saldo);
                    //iNumMes = iNumMes + 1;
                    //iNumMes += 1;

                }
            }
            Console.ReadLine();
        }
    }
}
