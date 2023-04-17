using System;

namespace FormatandoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            //Vai exibir somente o ano
            //var formatada = String.Format("{0:yyyy}", data);
            
            //Vai exibir o mês e o ano
            //var formatada = String.Format("{0:y}", data);
            //Console.WriteLine(formatada);

            //Vai exibir o mês e o dia
            //var formatada = String.Format("{0:M}", data);
            //Console.WriteLine(formatada);

            //var formatada = String.Format("{0:yyyy * MM * dd}", data);
            //Console.WriteLine(formatada);

            //var formatada = String.Format("{0:dd * MM * yyyy hh:mm:ss}", data);
            //Console.WriteLine(formatada);

            var formatada = String.Format("{0:dd * MM * yyyy hh:mm:ss ff z}", data);
            Console.WriteLine(formatada);
        }
    }
}