using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET__2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numar n: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;
            long P = 1;
            for (int i = 1; i <= n; i++)
            {
                S += i;
                P *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n}: {S}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n}: {P}");
            Console.ReadLine();
        }
    }
}