using System;

namespace Exercício9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 9 Desenvolva um algoritmo que calcule o IMC de uma determinada pessoa,
            e grave os resultados em um arquivo de texto, onde ao acessar a aplicação será solicitado
            se quer fazer um novo cadastro ou consultar os existentes.
            Cadastrando um novo calculo de IMC, será necessário informar o nome, idade, peso e altura.
            O cálculo do IMC é feito dividindo o peso (em quilogramas) pela altura (em metros) ao quadrado.
            Ao gravar em um arquivo de texto, os dados anteriores deverão ser mantidos.
            */

            string menuIniciar, nome, r, dados;
            int idade;
            float peso, altura, imc;
            
            

            Console.WriteLine("........................................"); //início do menu iniciar
            Console.WriteLine("Digite um valor:");
            Console.WriteLine("Novo usuário - 1");
            Console.WriteLine("Buscar Cadastro - 2");
            Console.WriteLine("Saír - 0");
            Console.WriteLine("........................................"); //Final do menu iniciar

            menuIniciar = Console.ReadLine();   //coletando com apenas uma variável
           
            Console.Clear(); // fechando o primeiro menu

            while (menuIniciar != "0")
            {
                if (menuIniciar == "1")
                {
                    //Inicio do cadastro do usuário
                    Console.WriteLine("Informe o seu nome:");    
                    nome = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Informe o sua idade:");
                    idade = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Informe o seu peso:");
                    peso = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Informe sua altura:");
                    altura = float.Parse(Console.ReadLine());
                    Console.Clear();
                    //Final do cadastro 

                    //Metodo para calcular o IMC
                    imc = peso / (altura * altura);

                    if (imc <= 18.5)
                    {
                        r = "Você esta abaixo do peso!";
                    }
                    else if ((imc <= 24.5) && (imc >= 18.5))
                    {
                        r = "Parabéns seu peso esta normal!";
                    }
                    else if ((imc <= 29.9) && (imc >= 25))
                    {
                        r = "Você esta acima do peso!";
                    }
                    else if ((imc <= 34.9) && (imc >= 30))
                    {
                        r = "Você esta com obesidade nível I !";
                    }
                    else if ((imc <= 39.9) && (imc >= 35))
                    {
                        r = "Você esta com obesidade nível II !";
                    }
                    else
                    {
                        r = "Você esta com obesidade nível III !";
                    }

                    //Sitema de armazenamento de dados, deve ser chamado a biblioteca "System.IO"
                    StreamWriter maquinaDeEscrever = new StreamWriter("exercicio 9.txt"); 

                    maquinaDeEscrever.WriteLine("Nome:   " + nome);
                    maquinaDeEscrever.WriteLine("Idade:   " + idade);
                    maquinaDeEscrever.WriteLine("Peso:   " + peso);
                    maquinaDeEscrever.WriteLine("Altura:   " + altura);
                    maquinaDeEscrever.WriteLine("IMC:   " + imc);
                    maquinaDeEscrever.WriteLine("Seu resultado:" + r);
                    maquinaDeEscrever.Close();
                    Console.WriteLine("*-----------------*");
                    Console.WriteLine("Cadastro realizado!");
                    Console.WriteLine("*-----------------*");
                }
                else if (menuIniciar == "2")
                {
                    
                    StreamReader mostrarNaTela = new StreamReader("exercicio 9.txt");

                    while ((dados = mostrarNaTela.ReadLine()) != null)
                    {                       
                        Console.WriteLine(dados);
                    }

                    mostrarNaTela.Close();                 
                }

                //intervalo entre o 1 loop e os seguintes
                Console.WriteLine("\nAperte enter");
                Console.ReadKey();
                Console.Clear();

                // Continuação para o loop, para que a tela não fique sem nenhuma informação
                Console.WriteLine("........................................"); 
                Console.WriteLine("Cadastrar novo usuário para IMC, digite - 1");
                Console.WriteLine("Buscar Cadastro, digite - 2");
                Console.WriteLine("Saír, digite - 0");
                Console.WriteLine("........................................"); 

                menuIniciar = Console.ReadLine();  
                Console.Clear();
                Console.ReadKey();
            }
        }
    }
}
