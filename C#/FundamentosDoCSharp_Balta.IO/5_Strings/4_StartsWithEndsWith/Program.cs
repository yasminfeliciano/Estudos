using System;

namespace StartsWithEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            //Starts With
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texto"));

            //Ends With
            Console.WriteLine(texto.StartsWith("teste"));
            Console.WriteLine(texto.StartsWith("Teste"));
            Console.WriteLine(texto.StartsWith("xpto"));

        }
    }
}