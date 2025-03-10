using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Sharp;

namespace C_Sharp_a1
{
    internal class Calculadora
    {

        public void Par()
        {
            int num;
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número ímpar");
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

       public void menuCalculadora()
        {
            Calculadora calculadora1 = new Calculadora();
            String menu = "Digite o número referente a operação que deseja executar:\n\n1 para soma\n2 para subtração\n3 para multiplicação \n4 divisão \n5 para saber se é par ou ímpar \n0 para sair";
            int op = 0;
            do
            {
                Console.WriteLine("▒▒▒░░░░░░░░░░▄▐░░░░\r\n▒░░░░░░▄▄▄░░▄██▄░░░\r\n░░░░░░▐▀█▀▌░░░░▀█▄░\r\n░░░░░░▐█▄█▌░░░░░░▀█▄\r\n░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀\r\n░░░░░▄▄▄██▀▀▀▀░░░░░\r\n░░░░█▀▄▄▄█░▀▀░░░░░░\r\n░░░░▌░▄▄▄▐▌▀▀▀░░░░░\r\n░▄░▐░░░▄▄░█░▀▀░░░░░\r\n░▀█▌░░░▄░▀█▀░▀░░░░░\r\n░░░░░░░░▄▄▐▌▄▄░░░░░\r\n░░░░░░░░▀███▀█░▄░░░\r\n░░░░░░░▐▌▀▄▀▄▀▐▄░░░\r\n░░░░░░░▐▀░░░░░░▐▌░░\r\n░░░░░░░█░░░░░░░░█░░\r\n░░░░░░▐▌░░░░░░░░░█░");
                Console.WriteLine(menu);
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {

                    case 1:

                        calculadora1.Somar();
                        break;
                    case 2:

                        calculadora1.Subtrair();
                        break;
                    case 3:

                        calculadora1.Multiplicar();
                        break;
                    case 4:

                        calculadora1.Dividir();
                        break;
                    case 5:

                        calculadora1.Par();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado!!!");

                        break;
                }
            } while (op != 0);






        
    }
    }
}
 