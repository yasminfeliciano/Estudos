using System;

namespace Equals
{
    class Program
    {
        static void Main(StringSplitOptions[] args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("Este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}