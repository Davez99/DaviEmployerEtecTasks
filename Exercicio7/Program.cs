using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 7 Desenvolva um algoritmo que calcule o reajuste salarial.
             Se o salário for abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00.
             Para finalizar, exiba o novo salário na tela.
            */

            Console.WriteLine("Digite o seu salário:");
            float salario = float.Parse(Console.ReadLine());
            float v = 0f;

            if (salario >= 1.700)
            {
                v = salario + 200;
            }
            else
            {
                v = salario + 300;
            }

            Console.WriteLine($"O seu reajuste salarial ficou em {v}");
            
            Console.ReadKey();
        }
    }
}
