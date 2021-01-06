using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 6 Desenvolva um algoritmo que solicite a entrada de uma frase,
             após isto troque todas as letras A ou a por &,
             porém não utilize o método Replace().
            */

            Console.WriteLine("Escreva uma frase ou texto: ");
            var text = Console.ReadLine();

            text [0] = "c";

            Console.WriteLine($"Sua conversão ficou assim: {text}");
            Console.ReadKey();

        }
    }
}
