using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menus
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op!=0)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo, escolha uma das seguintes opções");
                Console.WriteLine("1 - Opção A");
                Console.WriteLine("2 - Opção B");
                Console.WriteLine("3 - Opção C");
                Console.WriteLine("4 - Entrar no Submenu");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção A selecionada");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Opção B selecionada");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Opção C selecionada");
                    Console.ReadKey();
                }
                else if (op == 4)
                {
                    Submenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }

        private static void Submenu()
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Submenu");
                Console.WriteLine("1 - Opção A");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção A do Submenu selecionada");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }
    }
}
