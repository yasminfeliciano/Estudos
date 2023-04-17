using System;

namespace  InterpolacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //var texto = "O preço do produto é"+ price + " apenas na promoção ";
            //var texto = string.Format("O preço é {0} apenas na promoção", price);
            //var texto = $"O preço do produto é {price} apenas na promoção";

            //Para quebrar linha
            //var texto = $@"O preço do produto é {price} 
            //apenas na promoção";            
            var texto = $"O preço do produto é {price} \n apenas na promoção";
            Console.WriteLine(texto);
        }
    }
}