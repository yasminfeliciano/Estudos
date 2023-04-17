using System;
using System.Text;

namespace StringBuilderText
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenação
            var texto = "Este texto é um teste";
            texto += " aqui";

            //StringBuilder
            var textoBuilder = new StringBuilder();
            textoBuilder.Append("Este texto é um teste");
            textoBuilder.Append("é um teste");
            textoBuilder.Append("Este texto");
            textoBuilder.Append("Este um teste");

            textoBuilder.ToString();
            Console.WriteLine(textoBuilder);
        }
    }
}