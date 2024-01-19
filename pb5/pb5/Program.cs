using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lungimea secventei este de: ");
            int n = int.Parse(Console.ReadLine());
            int nregale = 0;
            Console.WriteLine("secventa de numere este: ");
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());

                if (nr == i)
                {
                    nregale++;
                }
            }z
            Console.WriteLine($"Numerele egale cu pozitia in secventa: {nregale}");
            Console.ReadLine();
        }
    }
}