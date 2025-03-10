using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Condicionais
    {

        public void Teste()
        {
            Console.WriteLine("Hello, Condicionais!");
        }

    
        // Exercícios 1

        public void MenorOuMaiorQue100()
        {
            int numero;
            Console.WriteLine("Lista de exercícios! \n\nExercício 1:");
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 100)
            {
                Console.WriteLine("Número maior que 100");
            }
            else if (numero < 100)
            {
                Console.WriteLine("Número menor que 100");
            }
            else
            {
                Console.WriteLine("Número digitado = a 100");

            }
        }


        // Exercício 2
        public void Eleitores()
        {
            int eleitores, votosBrancos, votosNulos, votosValidos;
            Console.WriteLine("Exercício 2 \n\n");
            Console.WriteLine("Digite o número de votos brancos:");
            votosBrancos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de votos nulos");
            votosNulos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de votos válidos");
            votosValidos = Convert.ToInt32(Console.ReadLine());
            eleitores = votosBrancos + votosNulos + votosValidos;
            Console.WriteLine("A porcentagem de votos brancos é de: " + (votosBrancos * 100) / eleitores + "%");
            Console.WriteLine("A porcentagem de votos nulos é de: " + (votosNulos * 100) / eleitores + "%");
            Console.WriteLine("A porcentagem de votos válidos é de: " + (votosValidos * 100) / eleitores + "%");
        }

        //Exercício 3

        public void MaiorOuMenorAnterior(int numero1)
        {
            int numero2;
            Console.WriteLine("Digite um número");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 > numero1)
            {
                Console.WriteLine("Número digitado maior que o parâmetro");
            }
            else if (numero2 < numero1)
            {
                Console.WriteLine("Número digitado menor que o parâmetro");
            }
            else
            {
                Console.WriteLine("Número digitado igual ao parâmetro");
            }


        }

        //Exercício 4

        public void MaiorNumero()
        {
            int num1, num2;
            Console.WriteLine("Digite o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " é maior que " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " é maior que " + num1);
            }
            else
            {
                Console.WriteLine(num1 + " é igual ao " + num2);
            }
        }

        //Exercício 5
        public void MenorNumero()
        {
            int primeiroNum, segundoNum;
            Console.WriteLine("Digite o primeiro número: ");
            primeiroNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            segundoNum = Convert.ToInt32(Console.ReadLine());
            if (primeiroNum < segundoNum)
            {
                Console.WriteLine(primeiroNum + "menor que " + segundoNum);
            }
            else if (primeiroNum > segundoNum)
            {
                Console.WriteLine(segundoNum + " é menor que " + primeiroNum);
            }
            else
            {
                Console.WriteLine(primeiroNum + "é igual a " + segundoNum);
            }
        }

        // Exercício 6
        public void Soma3Valores()
        {
            int v1, v2, v3, soma;
            Console.WriteLine("Digite o primeiro valor");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            v3 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2 + v3;
            Console.WriteLine("A soma dos 3 valores é: " + soma);
        }

        // Exercício 7
        public void ValorIntervalo(int valor1, int valor2)
        {
            int valorMaior, valorMenor, valorDigitado;
            if (valor1 > valor2)
            {
                valorMaior = valor1;
                valorMenor = valor2;
            }
            else
            {
                valorMaior = valor2;
                valorMenor = valor1;
            }
            Console.WriteLine("Digite um valor: ");
            valorDigitado = Convert.ToInt32(Console.ReadLine());
            if (valorDigitado > valorMenor && valorDigitado < valorMaior)
            {
                Console.WriteLine("Valor digitado entre os dois parâmetros");
            }
            else
            {
                Console.WriteLine("Valor fora do intervalo entre os dois parâmetros");

            }
        }
        // Exercício 8

        public void ParOuImpar(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine("Número par");

            }
            else
            {
                Console.WriteLine("Número ímpar");
            }

        }

        // Exercício 9 
        public void Notas()
        {
            float nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Digite a nota 1");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4");
            nota4 = float.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média é: " + media);
            if (media >= 7.5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        // Exercício 10 Menu

        public void menuCondicionais()
        {
            Condicionais condicionais = new Condicionais();
            int op = 10;
            do
            {
                Console.WriteLine("\n\n──────▄▀▄─────▄▀▄\r\n─────▄█░░▀▀▀▀▀░░█▄\r\n─▄▄──█░░░░░░░░░░░█──▄▄\r\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█\n\nSelecione o exercício: \n1 - Verificar se número é maior ou menor que 100 \n2 - Porcentagem Votos \n3 - Número maior ou menor que o parâmetro \n4 - Qual o maior número \n5 - Qual o menor número \n6 - Soma \n7 - Intervalo entre parâmetros \n8 - Par ou ímpar \n9 - Média \n0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());



                switch (op)
                {
                    case 1:
                        condicionais.MenorOuMaiorQue100();
                        break;

                    case 2:
                        condicionais.Eleitores();
                        break;

                    case 3:
                        condicionais.MaiorOuMenorAnterior(5);
                        break;

                    case 4:
                        condicionais.MaiorNumero();
                        break;

                    case 5:
                        condicionais.MenorNumero();
                        break;

                    case 6:
                        condicionais.Soma3Valores();
                        break;

                    case 7:
                        condicionais.ValorIntervalo(25, 50);
                        break;

                    case 8:
                        condicionais.ParOuImpar(7);
                        break;

                    case 9:
                        condicionais.Notas();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado!\n\n");
                        break;



                }



            } while (op != 0);



        }


    }

}
