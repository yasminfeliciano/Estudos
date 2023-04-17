using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Inicializando o array. Pode ser de qualquer tipo (var, int, string, bool, float, etc) e pode inicializar com valores ou não. O array de var precisa definir o tamanho, outros tipos não precisa definir o tamanho.
            var meuArray = new int[5]{1, 2, 3, 4, 5};

            //Mudando oou definindo um valor para a posição 0
            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            //Pode-se criar um Array de um Struct. É obrigado a definir o array na inicialização desse tipo (struct), ou logo abaixo dele.
            //var meuArray = new Teste[2]{new Teste(), new Teste()};
            //meuArray[0] = new Teste();
            //meuArray[1] = new Teste();

            //Pode-se acessar propriedades do array do tipo teste, caso este tenha.
            //Console.WriteLine(meuArray[0].Id);
            //Console.WriteLine(meuArray[1]);
            //Console.WriteLine(meuArray[2]);
            //Console.WriteLine(meuArray[3]);
            //Console.WriteLine(meuArray[4]);
        }
    }

    struct Teste
    {
        public int Id {get; set;}
    }
}