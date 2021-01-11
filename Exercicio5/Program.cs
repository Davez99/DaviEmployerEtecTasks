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

            
            NewMethod(NewMethod1()); 
        }

        private static void NewMethod(string nome)
        {
            Console.WriteLine("Olá meu nome é: {0}", nome);
            Console.ReadKey();
        }

        private static string NewMethod1()
        {
            Console.WriteLine("Escreva seu nome:");
            var nome = Console.ReadLine();
            Console.Clear();
            return nome;
        }
    }
}
