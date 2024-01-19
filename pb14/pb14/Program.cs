using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            bool monotonaRotita = VerificaMonotonaRotita(n);
            if (monotonaRotita)
            {
                Console.WriteLine("Secventa este o secventa monotona rotita");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Secventa nu este o secventa monotona rotita");
                Console.ReadLine();
            }
        }
        static bool VerificaMonotonaRotita(int n)
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
                
                int numar = int.Parse(Console.ReadLine());
                if (numar != numarAnterior)
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