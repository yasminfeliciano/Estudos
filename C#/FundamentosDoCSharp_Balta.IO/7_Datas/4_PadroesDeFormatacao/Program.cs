using System;

namespace PadroesDeFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;

            //t
            //Hora exibida no formato short(curto)
            //var formatada = String.Format("{0:t}", data);
            //Console.WriteLine(formatada);

            //d
            //Data exibida no formato short(curto)
            //var formatada = String.Format("{0:d}", data);
            //Console.WriteLine(formatada);

            //T
            //Hora exibida no formato long(longo)
            //var formatada = String.Format("{0:T}", data);
            //Console.WriteLine(formatada);
            
            //D
            //Data exibida no formato long(longo)
            //var formatada = String.Format("{0:D}", data);
            //Console.WriteLine(formatada);

            //f
            //Combina data e hora exibida no formato long(longo)
            //var formatada = String.Format("{0:f}", data);
            //Console.WriteLine(formatada);

            //g
            //Combina data e hora exibida no formato short(curto)
            //var formatada = String.Format("{0:g}", data);
            //Console.WriteLine(formatada);

            //r
            //Exibe data e hora de forma detalhada e padronizada
            //var formatada = String.Format("{0:r}", data);
            //Console.WriteLine(formatada);

            //s
            //Exibe data e hora de formatada para json
            //var formatada = String.Format("{0:s}", data);
            //Console.WriteLine(formatada);

            //u
            //Exibe data e hora de forma padronizada
            var formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);
        }
    }
}