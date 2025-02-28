using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Condicionais
    {

        public void Teste()
        {
            Console.WriteLine("HELLO CONDICIONAISSSS");
        }

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
    }
}
