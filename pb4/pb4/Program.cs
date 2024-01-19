using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lungimea secventei si numarul cautat sunt: ");
            int n = int.Parse(Console.ReadLine());

            int a = int.Parse(Console.ReadLine());
            int poz = PozA(n, a);
            if (poz != -1)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("-1");
                Console.ReadLine();
            }
        }
        static int PozA(int n, int a)
        {
            Console.WriteLine("secventa de numere este: ");
            for (int i = 0; i < n; i++)
            {
                
                int numar = int.Parse(Console.ReadLine());
                if (numar == a)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
