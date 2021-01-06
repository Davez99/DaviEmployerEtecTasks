using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2 Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.
            */
            Console.WriteLine("Qual é o seu nome:");
            var i = Console.ReadLine();
            Console.WriteLine($"O seu nome é {i}");
        }
    }
}
