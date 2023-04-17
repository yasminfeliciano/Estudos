using System;

namespace PercorrendoUmArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]{1, 2, 3, 4, 5};
            meuArray[0] = 12;

            //Para criar um array idêntico, mas pode ser altrado sem influenciar o original.
            //meuArray.Clone();

            //Para copiar valores de um array para outro
            //meuArray.CopyTo();

            //Vai pegar a quantidade de itens que possui no array
            //meuArray.Length

            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

            for (var index = 0; index < meuArray.Length ; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
        }
    }
}