using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicoes_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das seguintes opções");
            Console.WriteLine("1 - Criar ficheiro");
            Console.WriteLine("2 - Abrir ficheiro");
            Console.WriteLine("3 - Gravar ficheiro");
            Console.WriteLine("0 - Sair");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Escolheu a opção 1 - Criar um novo ficheiro");
                    break;
                case 2:
                    Console.WriteLine("Escolheu a opção 2 - Abrir um ficheiro existente");
                    break;
                case 3:
                    Console.WriteLine("Escolheu a opção 3 - Gravar o ficheiro");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (op == 1)
            {
                Console.WriteLine("Escolheu a opção 1 - Criar um novo ficheiro");
            }
            else if (op == 2)
            {
                Console.WriteLine("Escolheu a opção 2 - Abrir um ficheiro existente");
            }
            else if (op == 3)
            {
                Console.WriteLine("Escolheu a opção 3 - Gravar o ficheiro");
            }
            else if (op == 0)
            {

            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
