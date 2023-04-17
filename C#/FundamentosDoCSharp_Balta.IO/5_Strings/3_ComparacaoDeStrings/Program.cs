using System;

namespace ComparacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //var texto = "Testando";
            //Console.WriteLine(texto.CompareTo("Testando"));
            //Console.WriteLine(texto.CompareTo("testando"));

            var texto = "O texto contém a palavra teste?";
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Contains(null));
        }
    }
}