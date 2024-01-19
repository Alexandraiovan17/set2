using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool crescatoareRotita = CrescatoareRotita(n);
            if (crescatoareRotita)
            {
                Console.WriteLine("Secventa este o secventa crescatoare rotita");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa NU este o secventa crescatoare rotita");
                Console.ReadLine();
            }
        }
        static bool CrescatoareRotita(int n)
        {
            if (n <= 1)
            {
                return true;
            }
            Console.Write("Introduceti primul numar de pe pozitia 0: ");
            int primulNumar = int.Parse(Console.ReadLine());
            int numarAnterior = primulNumar;
            bool Rotire = false;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar = int.Parse(Console.ReadLine());
                if (numar < numarAnterior)
                {
                    if (Rotire)
                    {
                        return false;
                    }
                    else
                    {
                        Rotire = true;
                    }
                }
                numarAnterior = numar;
            }
            return true;
        }
    }
}