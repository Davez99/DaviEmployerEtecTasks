using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              EX - 1  Desenvolva um algoritmo que solicite a entrada de um número e 
              calcule se o número é par ou impar.
            */

            Console.WriteLine("Escreva um número");
            var i  = float.Parse(Console.ReadLine());

            if (i%2 == 0)
            {
                Console.WriteLine("O Seu número é par");
            }
            else
            {
                Console.WriteLine("Seu número é impar");
            }

        }
    }
}
