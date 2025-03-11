using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_a1
{
    internal class Calculadora
    {


        public void tabuada()
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
