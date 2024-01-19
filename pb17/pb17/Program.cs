using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduceti secventa de 0 si 1 ");
            string input = Console.ReadLine();
            int nivelmax = 0;
            int nivelcurent = 0;
            foreach (char c in input)
            {
                if (c == '0')
                {
                    nivelcurent++;
                }
                else if (c == '1')
                {
                    if (nivelcurent > 0)
                    {
                        nivelcurent--;
                    }
                    else
                    {
                        Console.WriteLine("Secventa este incorecta");
                        Console.ReadLine();
                        return;
                    }
                }
                nivelmax = Math.Max(nivelmax, nivelcurent);
            }
            if (nivelcurent == 0)
            {
                Console.WriteLine("Secventa este corecta si nivelul maxim de incuibare este " + nivelmax);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa este incorecta");
                Console.ReadLine();
            }
        }

    }
}
