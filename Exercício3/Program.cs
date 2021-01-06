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

            Console.WriteLine("Digite o primeiro número; ");
             
            var num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer? escreva com os sinais '+, -, *, /' :  ");

            var operacao = Console.ReadLine();

            Console.WriteLine("Qual é o segundo número: ");

            var num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
                   
            }
            Console.WriteLine("O resultado é\n {0} {1} {2} = {3}", num1, operacao, num2, resultado);
            Console.ReadKey(true);
        }
    }
}
