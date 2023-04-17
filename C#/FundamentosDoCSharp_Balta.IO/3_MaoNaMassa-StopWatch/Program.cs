using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();    
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto = 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            //Pegando o último caracter digitado(letra "s"), usando data.Length-1 para marcar onde começa, pois a contagem começa no zero, mas a quantidade não, e 1 para a quantidade de caracters.
            char type = char.Parse(data.Substring(data.Length-1,1));
            //Pegando Todos os primeiros caracteres digitado("time" em números), usando 0 para marcar onde começa e data.Length-1 para a quantidade, pois a contagem começa no zero, mas a quantidade não.
            int time = int.Parse(data.Substring(0,data.Length-1));

            int multiplier = 160;
            if(type == 'm')
            {
                multiplier = 60;
            }

            if(time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }
        
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}