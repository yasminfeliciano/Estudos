using System;

namespace AlterandoOsValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var arr = new int[4];
            //Não está sendo criado um array novo, somente está apontando para um mesmo endereço na memória.
            var arrb = arr;
            
            arr[0] = 23;
            Console.WriteLine(arrb[0]);
//--------------------------------------------------------

            var primeiro = new int [4];
            var segundo = new int [4];

            //Nesse caso são dois arrays com elementos iguais inicialmente.
            segundo[0] = primeiro[0];
            
            //Também pode se usar o CopyTo para copiar um array para o outro.
            //primeiro.CopyTo(segundo, 0);

            //Porém ao alterar um dos elementos, o elemento correspondente do outro array não se altera porque cada um dos arrays estão alocados em endereços diferentes da memória, apesar de serem iguais.
            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);
//--------------------------------------------------------
            

            
        }
    }
}