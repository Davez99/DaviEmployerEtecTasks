using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Ex 3 Desenvolva uma calculadora, 
              onde será necessário entrar com a operação, primeiro e segundo valor, 
              exiba o resultado na tela.
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
