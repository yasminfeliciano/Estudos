using System;
using System.Globalization;

namespace CultureInfoDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Pode-se usar tanto "System.Globalization.CultureInfo" quanto o "CultureInfo", o resultado é o mesmo
            //var pt = new System.Globalization.CultureInfo("pt-BR");
            var ptBr = new CultureInfo("pt-BR");
            var ptPt = new CultureInfo("pt-PT");
            var enUs = new CultureInfo("en-US");
            var enUk = new CultureInfo("en-UK");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
          
            Console.WriteLine(string.Format("{0:D}", DateTime.Now));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
        }
    }
}