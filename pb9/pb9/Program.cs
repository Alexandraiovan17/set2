using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți numărul de elemente din secvență: ");
            int n = int.Parse(Console.ReadLine());

            // Inițializarea variabilei pentru stocarea valorii anterioare
            int valoareAnterioara = int.MinValue;
            bool esteCrescatoare = true;
            bool esteDescrescatoare = true;

            Console.WriteLine("introduceti elementele: ");
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());

                if (numar < valoareAnterioara)
                {
                    esteCrescatoare = false;
                }

                if (numar > valoareAnterioara)
                {
                    esteDescrescatoare = false;
                }

                valoareAnterioara = numar;
            }

            if (esteCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else if (esteDescrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }
        }
    }
}
