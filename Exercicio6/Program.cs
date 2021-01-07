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
            var texto = Console.ReadLine();
            Console.Clear();


            char[] letra = new char[200];
            letra = texto.ToCharArray();


            for (int i = 0; i < letra.Length;  i++) 
            {
                while(letra[i] == 'a')
                {
                    letra[i] = '&';
                }
            }

            Console.WriteLine($"Sua conversão ficou assim:");
            Console.WriteLine(letra);
            Console.ReadKey();

        }
    }
}