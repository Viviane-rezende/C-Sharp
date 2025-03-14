using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_a1
{
    internal class Calculadora
    {

        public void ListaCarros()
        {
            string[] carros = { "BMW", "JEEP", "VOLVO"                  //declaracao de array com 3 valores indice 2
            };
            Console.WriteLine(carros[0]);

            Console.WriteLine(carros.Length);

            for (int i = 0; i <= carros.Length; i++)
            {
                Console.WriteLine(carros[i]);                           //printando todos os valores do array percorrendo ele com for 
            }
        }


        public void ListaCoresPercorridaComForEach()
        {
            string[] cores = { "azul", "amarelo", "vermelho", "rosa", "preto" };        //foreach é focado em percorrer arrays
            foreach (string item in cores)
            {
                Console.WriteLine(item);
            }
        }


        public void Roupas() {
            string[] roupas = new string[3];            //aqui estou criando um array com indice 2
            for (int i=0; i <roupas.Length; i++)
            {
                Console.WriteLine("Digite a roupa:");
                roupas[i] = Console.ReadLine();

            }

            foreach (string item in roupas)
            {
                Console.WriteLine(roupas.Length);
                
            }
            
         
        }



        public void Tabuada()
        {
            int valor1, valor2;

            for (valor1 = 0; valor1 <= 10; valor1++)
            {
                Console.WriteLine("");
                for (valor2 = 0; valor2 < 10; valor2++)
                    Console.Write(valor1 + " * " + valor2 + " = " + valor1 * valor2 + "\t");
                //Console.Write($"{valor1} X {valor2} = {valor1*valor2}\t");

            }
        }

        public void Ternario()
        {
            int num = 10;
            Console.WriteLine((num == 10) ? "Número igual a  10, verdadeiro" : "Número diferente de 10, falso. ");

        }
        public void FuncaoSoma(int n1, int n2)
        {
            int resultado;
            resultado = n1 + n2;
            Console.WriteLine("O resultado da soma é " + resultado);

        }

        public void FuncaoSub(int n1, int n2)
        {
            int resultado;
            resultado = n1 - n2;
            Console.WriteLine("O resultado da subtração é " + resultado);

        }

        public void FuncaoMult(int n1, int n2)
        {
            int resultado;
            resultado = n1 * n2;
            Console.WriteLine("O resultado da multiplicação é " + resultado);

        }

        public void FuncaoDivisao(int n1, int n2)
        {
            int resultado;
            resultado = n1 / n2;
            Console.WriteLine("O resultado da divisão é " + resultado);

        }

        public void CalculaAreaRetangulo(int baseR, int altura)
        {
            int area;
            area = baseR * altura;
            Console.WriteLine("A área é: " + area);
        }



        public void Somar()
        {
            int n1, n2, resultado;
            Console.WriteLine("Você escolheu somar! \nDigite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        public void Subtrair()
        {
            int n1, n2, resultado;
            Console.WriteLine("Você escolheu subtrair! \nDigite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 - n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        public void Multiplicar()
        {
            int n1, n2, resultado;
            Console.WriteLine("Você escolheu multiplicar! \nDigite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 * n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        public void Dividir()
        {
            int n1, n2, resultado;
            Console.WriteLine("Você escolheu Dividir! \nDigite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 / n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }
    }
}
