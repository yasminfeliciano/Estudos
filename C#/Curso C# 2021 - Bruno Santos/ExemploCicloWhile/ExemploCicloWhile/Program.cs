using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=============================");

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int num = 1, soma = 0;
            while (num != 0)
            {
                Console.WriteLine("insira um número para somar! Insira 0 para parar");
                num = int.Parse(Console.ReadLine());

                soma += num;
            }
            Console.WriteLine("A soma de todos os números inseridos é: " + soma);

            int num2, soma2 = 0;
            do
            {
                Console.WriteLine("insira um número para somar! Insira 0 para parar");
                num2 = int.Parse(Console.ReadLine());

                soma2 += num2;
            } while (num2 != 0);
        }
    }
}
