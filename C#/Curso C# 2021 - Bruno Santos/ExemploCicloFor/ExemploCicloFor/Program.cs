using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Insira um número");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("A soma de todos os valores inseridos é: "+soma);
        }
    }
}
