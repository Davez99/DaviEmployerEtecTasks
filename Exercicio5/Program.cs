using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 5 Desenvolva um método que receba por parâmetro o um nome,
            e retorne a frase “Olá meu nome é: { nome recebido}”.
            */

            Console.WriteLine("Escreva seu nome:");
            var nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Olá meu nome é: {0}", nome);
            Console.ReadKey();
        }
    }
}
