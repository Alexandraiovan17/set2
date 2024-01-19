using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int numarCurent, numarPrecedent, lungimeCurenta, lungimeMaxima;
            lungimeCurenta = lungimeMaxima = 1;

            Console.Write("Introduceti primul numar: ");
            numarPrecedent = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti urmatorul numar: ");
                numarCurent = int.Parse(Console.ReadLine());
                if (numarCurent == numarPrecedent)
                {
                    lungimeCurenta++;
                }
                else
                {
                    if (lungimeCurenta > lungimeMaxima)
                    {
                        lungimeMaxima = lungimeCurenta;
                    }

             
                    lungimeCurenta = 1;
                }
        
                numarPrecedent = numarCurent;
            }
        
            if (lungimeCurenta > lungimeMaxima)
            {
                lungimeMaxima = lungimeCurenta;
            }

            Console.WriteLine($"numarul maxim de numere consecutive egale este de: {lungimeMaxima}");
        }
    }
    }

