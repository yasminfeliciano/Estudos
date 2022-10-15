using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo, escolha uma das seguintes opções");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    Somar();
                }
                else if (op == 2)
                {
                    Subtracao();
                }
                else if (op == 3)
                {
                    Multiplicacao();
                }
                else if (op == 4)
                {
                    Divisao();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        private static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " x " + n2 + " = " + (n1 * n2));

            Console.ReadKey();
        }

        private static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));

            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));

            Console.ReadKey();
        }

        private static void Somar()
        {
            Console.Clear();
            Console.WriteLine("Insira o primeiro número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 + " + " + n2 + " = "+(n1 + n2));
            
            Console.ReadKey();
        }
    }
}
