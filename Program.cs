using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el número:");
            double i, acum, n;
            acum = 1;
            n = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            for (i=2; i<(n/2); i++)
            {
                if (n%2==0)
                {
                    acum = acum + i;
                }
                if (n==acum)
                {
                    Console.WriteLine("el número es perfecto");
                }
                else
                {
                    Console.WriteLine("el número no es perfecto");
                    Console.ReadKey();
                }
            }
        }
    }
}
