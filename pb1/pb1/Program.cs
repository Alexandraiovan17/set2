using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        // cate numere sunt pare
        {
            Console.WriteLine("lungimea secventei: ");
            int lungime = int.Parse(Console.ReadLine());
            int nrPare = 0;
            for (int i = 0; i < lungime; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}: ");
                int nr = int.Parse(Console.ReadLine());
                if (Par(nr))
                {
                    nrPare++;
                }
            }
            Console.WriteLine($"Dintre cele {lungime} numere, {nrPare} sunt pare.");
            Console.ReadLine();
        }
        static bool Par(int numar)
        {
            return numar % 2 == 0;
        }
    }
}