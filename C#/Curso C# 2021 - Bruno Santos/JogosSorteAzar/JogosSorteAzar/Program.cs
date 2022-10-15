using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosSorteAzar
{
    class Program
    {
        static Random rnd = new Random();
        static string nome = "";
        static int saldo = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("Bem Vindo, "+nome+"\tSaldo: "+saldo);
                Console.WriteLine("Escolha uma das seguintes opções");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Levantamentos/Depósitos");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinhas();
                        break;
                    case 3:
                        Banca();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Banca()
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo, " + nome);
                Console.WriteLine("Menu Levantamento e Depósito\t\tSaldo: " + saldo);
                Console.WriteLine("Escolha uma das seguintes opções");
                Console.WriteLine("1 - Levantamento");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Levantamento();
                        break;
                    case 2:
                        Deposito();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Deposito()
        {
            Console.Clear();

            Console.WriteLine("Saldo atual: " + saldo);
            Console.WriteLine("Qual o valor a depositar?");
            int valor = int.Parse(Console.ReadLine());

            saldo += valor;

            Console.WriteLine("Depósito realizado com sucesso, novo saldo: " + saldo);

            Console.ReadKey();
        }

        private static void Levantamento()
        {
            Console.Clear();

            Console.WriteLine("Saldo atual: " + saldo);
            Console.WriteLine("Qual o valor a levantar?");
            int valor = int.Parse(Console.ReadLine());

            if (saldo - valor < 0)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                saldo -= valor;

                Console.WriteLine("Levantamento realizado com sucesso, novo saldo: " + saldo);
            }

            Console.ReadKey();
        }

        private static void Raspadinhas()
        {
            int op = 1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu Raspadinhas");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Voltar ao menu anterior");
                op = int.Parse(Console.ReadLine());

                if(op == 0)
                {
                    break;
                }
                else if (op == 1)
                {
                    RaspadinhaA();
                }
                else if (op == 2)
                {
                    RaspadinhaB();
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }

            }
        }

        private static void RaspadinhaB()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 2;

            int nPrincipal = rnd.Next(1, 10);
            int premio = rnd.Next(1, 10);

            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);

            int cont = 0;
            if (nPrincipal == n1) cont++;
            if (nPrincipal == n2) cont++;
            if (nPrincipal == n3) cont++;
            if (nPrincipal == n4) cont++;
            if (nPrincipal == n5) cont++;
            if (nPrincipal == n6) cont++;
            if (nPrincipal == n7) cont++;
            if (nPrincipal == n8) cont++;
            if (nPrincipal == n9) cont++;

            Console.WriteLine("Número principal: " + nPrincipal + "(" + premio + ")");
            Console.WriteLine(n1 + " " + n2 + " " + n3);
            Console.WriteLine(n4 + " " + n5 + " " + n6);
            Console.WriteLine(n7 + " " + n8 + " " + n9);

            if (cont >= 3)
            {
                Console.WriteLine("Parabéns foi premiado!! Ganhou " + premio);
                saldo += premio;
            }
            else
                Console.WriteLine("Raspadinha não premiada");

            Console.ReadKey();
        }

        private static void RaspadinhaA()
        {
            Console.Clear();
            if (saldo - 2 < 0)
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 2;

            int nPrincipal = rnd.Next(1, 10);
            int n1 = rnd.Next(1, 10);   int p1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 10);   int p2 = rnd.Next(1, 100);
            int n3 = rnd.Next(1, 10);   int p3 = rnd.Next(1, 100);
            int n4 = rnd.Next(1, 10);   int p4 = rnd.Next(1, 100);
            int n5 = rnd.Next(1, 10);   int p5 = rnd.Next(1, 100);

            Console.WriteLine("Número principal: " + nPrincipal);
            Console.WriteLine("1º Número: " + n1 + "(" + p1 + ")");
            Console.WriteLine("2º Número: " + n2 + "(" + p2 + ")");
            Console.WriteLine("3º Número: " + n3 + "(" + p3 + ")");
            Console.WriteLine("4º Número: " + n4 + "(" + p4 + ")");
            Console.WriteLine("5º Número: " + n5 + "(" + p5 + ")");

            int premio = 0;

            if (n1 == nPrincipal) premio += p1;
            if (n2 == nPrincipal) premio += p2;
            if (n3 == nPrincipal) premio += p3;
            if (n4 == nPrincipal) premio += p4;
            if (n5 == nPrincipal) premio += p5;

            Console.WriteLine("Prêmio: " + premio);
            saldo += premio;

            Console.ReadKey();
        }

        private static void Loteria()
        {
            Console.Clear();
            if (saldo - 5 < 0)
            {
                Console.WriteLine("Saldo insuficiente, realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 5;

            int nPremiado = rnd.Next(1000, 10000);
            int nJogador = 0;

            while(nJogador < 1000 || nJogador > 9999) { 
                Console.WriteLine("Qual o número que quer jogar na Loteria?");
                nJogador = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Bilhete premiado: " + nPremiado);

            if (nPremiado == nJogador)
            {
                Console.WriteLine("PARABÉNS, GANHOU O 1º PRÊMIO!");
                saldo += 10000;
            }
            else if(nPremiado%1000 == nJogador%1000){
                Console.WriteLine("PARABÉNS, GANHOU O 2º PRÊMIO!");
                saldo += 1000;
            }
            else if(nPremiado % 100 == nJogador % 100)
            {
                Console.WriteLine("PARABÉNS, GANHOU O 2º PRÊMIO!");
                saldo += 100;
            }
            else
            {
                Console.WriteLine("O seu bilhete não foi premiado");
            }

            Console.ReadKey();
           
        }
    }
}
