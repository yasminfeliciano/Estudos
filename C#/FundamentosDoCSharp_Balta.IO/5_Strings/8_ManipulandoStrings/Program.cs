using System;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(StringSplitOptions[] args)
        {
            var texto = " Este texto é um teste ";
            
            //Replace
            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("e", "X"));
            Console.WriteLine(texto.Replace("xxxxx", "X"));

            //Splite
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[0]);

            //Substring
            //var resultado = texto.Substring(5, 5);
            var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            Console.WriteLine(resultado);

            //Trim
            Console.WriteLine(texto.Trim());
        }
    }
}