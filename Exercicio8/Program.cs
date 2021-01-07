using System;
using System.IO;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 8 Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e RG
             de um determinado usuário e grave em um arquivo de texto.
             Exiba as informações na tela a partir do arquivo de texto gerado.
            */

            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu e-mail:");
            var email = Console.ReadLine();

            Console.WriteLine("Digite seu RG:");
            var rg = Console.ReadLine();
            Console.Clear();

            StreamWriter maquinaDeEscrever = new StreamWriter("exercicio 8.txt");

            maquinaDeEscrever.WriteLine(nome);
            maquinaDeEscrever.WriteLine(email);
            maquinaDeEscrever.WriteLine(rg);
            maquinaDeEscrever.Close();

            Console.WriteLine("Foi gerado o arquivo .txt");

            string dados = "";
            StreamReader mostrarNaTela = new StreamReader("exercicio 8.txt");
             
            while ((dados = mostrarNaTela.ReadLine()) != null)
            {
                Console.WriteLine(dados);
            }


            Console.ReadKey();
        }
    }
}
