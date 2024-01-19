using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("intrroduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int ultnr = int.MinValue;
            Console.WriteLine("introduceti secventa:");
            for (int i = 0; i < n; i++)
            {
               // Console.Write($"Elementul {i + 1}: ");
                int nrcurent = int.Parse(Console.ReadLine());
                if (nrcurent <= ultnr)
                {
                    Console.WriteLine("secventa nu este în ordine crescatoare.");
                    return;
                }

                ultnr = nrcurent;
            }
            Console.WriteLine("secventa este în ordine crescatoare.");
        }
    }
    }

