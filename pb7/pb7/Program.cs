using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introd. nr de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int valMax = int.MinValue;
            int valMin = int.MaxValue;
            Console.WriteLine("introd. elementele :");
            for (int i = 0; i < n; i++)
            {
                int numar = int.Parse(Console.ReadLine());

                if (numar > valMax)
                {
                    valMax= numar;
                }

                if ( numar < valMin)
                {
                    valMin = numar;
                }
            }
            Console.WriteLine($"cea mai mare val: {valMax}");
            Console.WriteLine($"cea mai mica val: {valMin}");
        }
    }
    }

