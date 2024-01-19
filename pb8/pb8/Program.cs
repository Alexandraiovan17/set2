using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduceti n ");
            int n = int.Parse(Console.ReadLine());

            // Calculul al n-lea număr Fibonacci
            int fibN = Fibonacci(n);

            // Afișarea rezultatului
            Console.WriteLine($"al {n}-lea numar din sirul lui Fibonacci este: {fibN}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    }

