using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            double sumaInverselor =SumaInverselor(n);
            Console.WriteLine($"suma inverselor numerelor din secventa este: {sumaInverselor}");
            Console.ReadLine();
        }
        static double SumaInverselor(int lungime)
        {
            double sumaInverselor = 0;
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                double numar = double.Parse(Console.ReadLine());
                sumaInverselor += 1 / numar;
            }
            return sumaInverselor;
        }
    }
    }
 