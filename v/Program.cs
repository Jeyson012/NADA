using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace determinnte
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[20, 20];
            Console.WriteLine("BIENVENIDO AL PROGRAMA");
            Console.WriteLine("DETERMINANTE DE UNA MATRIZ DE N X N");
            Console.WriteLine("INGRESE EL TAMAÑO DE LA MATRIZ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("POSICIÓN [{0}-{1}]:", i + 1, j + 1);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write("| " + matriz[i, j] + " |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            //Formula para la determinante
            //diagonal principal - diagonal inversa
            int termin = 7;//{0}
            //MÉTODO DE SARRUS 
            //termin = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) + (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) + (matriz[0, 1] * matriz[1, 2] * matriz[2, 0])) - ((matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) + (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]) + (matriz[1, 2] * matriz[2, 1] * matriz[0, 0]));
            //METODO POR MENOR
            termin = matriz[0, 0] * ((matriz[1, 1] * matriz[2, 2]) - (matriz[2, 1] * matriz[1, 2])) - matriz[0, 1] * ((matriz[1, 0] * matriz[2, 2]) - (matriz[2, 0] * matriz[1, 2])) + matriz[0, 2] * ((matriz[1, 0] * matriz[2, 1]) - (matriz[2, 0] * matriz[1, 1]));
            int m1 = 0, m2 = 0, m3 = 0, r = 0;
            Console.WriteLine("PRIMER PROCESO");
            m1 = matriz[0, 0] * ((matriz[1, 1] * matriz[2, 2]) - (matriz[2, 1] * matriz[1, 2]));
            Console.WriteLine(matriz[0, 0] + "*((" + matriz[1, 1] + "*" + matriz[2, 2] + ")-(" + matriz[2, 1] + "*" + matriz[1, 2] + "))   =" + m1);
            Console.WriteLine("");
            Console.WriteLine("SEGUNDO PROCESO");
            m2 = -1 * (matriz[0, 1] * ((matriz[1, 0] * matriz[2, 2]) - (matriz[2, 0] * matriz[1, 2])));
            Console.WriteLine("");
            Console.WriteLine("-(" + matriz[0, 1] + "*((" + matriz[1, 0] + "*" + matriz[2, 2] + ")-(" + matriz[2, 0] + "*" + matriz[1, 2] + ")))=" + m2);
            Console.WriteLine("");
            Console.WriteLine("TERCER PROCESO");
            m3 = matriz[0, 2] * ((matriz[1, 0] * matriz[2, 1]) - (matriz[2, 0] * matriz[1, 1]));
            Console.WriteLine(matriz[0, 2] + "*((" + matriz[1, 0] + "*" + matriz[2, 1] + ")-(" + matriz[2, 0] + "*" + matriz[1, 1] + "))   =" + m3);
            r = m1 + m2 + m3; Console.WriteLine("");
            Console.WriteLine("SUMAR LOS PROCESOS:" + m1 + m2 + m3 + "=" + r);
            Console.WriteLine("");
            Console.WriteLine("LA DETERMINANTE DE LA MATRIZ ES: {0}", termin);
            Console.WriteLine("");
            Console.WriteLine("AUTORES DEL PROGRAMA:");
            Console.WriteLine("                     ABAD CARLOS");
            Console.WriteLine("                     LEÓN MELANIE");
            Console.WriteLine("                     PANTOJA JEYSON");
            Console.WriteLine("                     SÁNCHEZ KATHERINE");
            Console.WriteLine("                     VALAREZO MARIA");
            Console.WriteLine("PRESIONE UNA TECLA..."); Console.ReadKey();
        }
    }
}
