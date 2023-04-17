using System;

namespace ComparandoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //DateTime? data = null; //DateTime.Now

            var data = DateTime.Now;

            //A sentença "data == DateTime.Now" sempre será falsa, pois ele irá considerar cada milésimo de segundo, e entre o instanciamento da variável "var" e a leitura dela no código se passou milésimos de segundo de diferença.
            if(data == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }

            //No caso a seguir pede-se que seja considerado apenas a data (dd/MM/yyyy) e não o tempo total, portanto a sentença "data.Date == Datetime.Now" agora é verdadeira.
            if(data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("A data é igual");
            }

            Console.WriteLine(data.Date);
        }
    }
}