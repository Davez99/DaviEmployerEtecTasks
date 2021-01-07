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

            float i, escolha;

            do
            {
                Console.WriteLine("Escreva um número");
                i = float.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    Console.WriteLine("O Seu número é par");
                }
                else
                {
                    Console.WriteLine("Seu número é impar");
                }

                Console.WriteLine("Mais uma vez?  1 - sim 2 - não");
                escolha = int.Parse(Console.ReadLine());

                Console.Clear();

            } while ( escolha != 2);
        }
    }
}
