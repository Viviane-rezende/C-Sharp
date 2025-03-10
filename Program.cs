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
            Condicionais cond = new Condicionais();
            Calculadora calculadora = new Calculadora();
            int op;

            do
            {

                Console.WriteLine("▒▒▒▒▒▒▒▒█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\r\n▒▒▒▒▒▒▒█░▒▒▒▒▒▒▒▓▒▒▓▒▒▒▒▒▒▒░█\r\n▒▒▒▒▒▒▒█░▒▒▓▒▒▒▒▒▒▒▒▒▄▄▒▓▒▒░█░▄▄\r\n▒▒▄▀▀▄▄█░▒▒▒▒▒▒▓▒▒▒▒█░░▀▄▄▄▄▄▀░░█\r\n▒▒█░░░░█░▒▒▒▒▒▒▒▒▒▒▒█░░░░░░░░░░░█\r\n▒▒▒▀▀▄▄█░▒▒▒▒▓▒▒▒▓▒█░░░█▒░░░░█▒░░█\r\n▒▒▒▒▒▒▒█░▒▓▒▒▒▒▓▒▒▒█░░░░░░░▀░░░░░█\r\n▒▒▒▒▒▄▄█░▒▒▒▓▒▒▒▒▒▒▒█░░█▄▄█▄▄█░░█\r\n▒▒▒▒█░░░█▄▄▄▄▄▄▄▄▄▄█░█▄▄▄▄▄▄▄▄▄█\r\n \nEscolha um menu: \n 1 - Menu Condicionais \n 2 - Menu Calculadora \n 0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        cond.menuCondicionais();
                        break;
                    case 2:
                        calculadora.menuCalculadora();
                        break;
                    case 0:
                        Console.WriteLine("Muito obrigado!");
                        break;

                }
                }   while (op != 0) ;
            
        }
    }
}











