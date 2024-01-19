using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int neg = 0;
            int zero = 0;
            int poz = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    neg++;
                }
                else if (num == 0)
                {
                    zero++;
                }
                else
                {
                    poz++;
                }
            }
            Console.WriteLine($"Numere negative: {neg}");
            Console.WriteLine($"Numere zero: {zero}");
            Console.WriteLine($"Numere pozitive: {poz}");
        }

    }
}