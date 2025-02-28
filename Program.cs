using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using C_Sharp;

namespace C_Sharp_a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Apresentacao ap = new Apresentacao();


        Calculadora calculadora1 = new Calculadora();
        
        Condicionais cond = new Condicionais();
       


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

                        cond.Par();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado!");

                        break;
                }
            } while (op != 0) ;






        }
    }
}












/*
 *      Apresentacao ap1 = new Apresentacao();
            Calculadora calculadora1 = new Calculadora();
            ap1.Saudacao("Vivi");
            //calculadora1.Soma();
            calculadora1.FuncaoSoma(10, 02);
            calculadora1.FuncaoSub(20, 10);
            calculadora1.FuncaoMult(7, 7);
            calculadora1.FuncaoDivisao(25, 25);
            calculadora1.CalculaAreaRetangulo(20, 10);

 * 
 * public void Saudacao(String nome)
{
    Console.WriteLine("Hello World! " + nome);
}

float n1, n2, soma;


String nome;
int idade;
DateTime dataHoje = DateTime.Now;

Using 'WriteLine' to break lines

 Console.WriteLine("Viviane Rezende Silva");
Console.WriteLine("29");
Console.WriteLine("25/02/2025");

// Using 'Write' that doesn't read lines and using '\n' to break lines

Console.Write("\nViviane Rezende Silvaz\n");
Console.Write("29\n");
Console.Write("25/02/2025\n");

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();                      //readline only read Strings

Console.WriteLine("Qual a sua idade?");
//idade= Int32.Parse(Console.ReadLine());
idade = Convert.ToInt32(Console.ReadLine());    //here we are using the function Convert to convert Int to String and read it
                                                //idade = Int32.Parse(null);                    
                                                //idade = Convert.ToInt32(null);

Console.WriteLine("A data de hoje é: " + dataHoje.ToString
("dd/MM/yyyy"));

Console.WriteLine(nome);
Console.WriteLine(idade);

Console.WriteLine("Seu nome é: " + nome + ", sua idade é: " + idade + " e a data de hoje é: " + dataHoje);


Console.WriteLine("Digite o primeiro número:");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
n2 = Convert.ToInt32(Console.ReadLine());
soma = n1 + n2;
Console.WriteLine("O resultado da soma é: " + soma);
Console.WriteLine($"O resultado {0} da soma é: ", soma);


Console.WriteLine("Digite o primeiro número:");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
n2 = float.Parse(Console.ReadLine());
soma = n1 + n2;
Console.WriteLine("O resultado da soma é: " + soma); */

