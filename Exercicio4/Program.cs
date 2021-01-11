using System;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              4 – Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
              se for menor que 18 anos exiba na cor vermelha “Sem permissão”,
              caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.
             */
            try {
                Console.WriteLine("Precisamos saber qual é sua idade, para permitir ou não sua entrada:");

                var idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Permissão concedida");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sem Permissão");
                }

                Console.ReadKey();
                Console.ReadKey(true);
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números");
            }
        }
    }
}
