using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET2._16
{
    internal class Program
    {       static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            if (IsBitonicRotatedSequence(n))
            {
                Console.WriteLine("Secventa este bitonica rotita.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica rotita.");
                Console.ReadLine();
            }
        }
        static bool IsBitonicRotatedSequence(int n)
        {
            if (n < 3)
            {
                return false;
            }
            Console.Write("Introduceti primul element al secventei: ");
            int primul = int.Parse(Console.ReadLine());
            int prev = primul;
            bool creste = true;
            bool descreste = false;
            for (int i = 1; i < n; i++)
            {
                Console.Write("Introduceti urmatorul element: ");
                int curent = int.Parse(Console.ReadLine());
                if (curent == prev)
                {
                    return false;
                }
                if (curent > prev)
                {
                    if (descreste)
                    {
                        return false;
                    }
                    creste = true;
                }
                else
                {
                    creste = true;
                }
                if (descreste && curent > primul)
                {
                    return true;
                }
                prev = curent;
            }
            return false;
        }
        
    }
}
