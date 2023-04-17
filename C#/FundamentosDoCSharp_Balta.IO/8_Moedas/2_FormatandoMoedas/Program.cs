using System;
using System.Globalization;

namespace FormatandoMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            //ToString com CultureInfo - Transforma o tipo de representação da moeda, com vírgula ou ponto dependendo do país.
            Console.WriteLine(
                valor.ToString(
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            //G - Formatador numérico, será representado como um número padrão.
            Console.WriteLine(
                valor.ToString(
                    "G",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );
            
            //F - Maior precisão na exibição da moeda, com uma única vírgula para separar.
            Console.WriteLine(
                valor.ToString(
                    "F",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            //N - Formata como valor, com um pouco mais precisão, porém com ponto e vírgula para separar casas decimais.
            Console.WriteLine(
                valor.ToString(
                    "N",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            //P - Transforma o valor em porcentagem
            Console.WriteLine(
                valor.ToString(
                    "P",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );
            
            //C - Formata colocando o padrão da moeda especificada, R$, $, £, etc.
            Console.WriteLine(
                valor.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );
            
            //E04 - Para valores maiores deixa em notação científica. Ex: 1,025E+001.
            Console.WriteLine(
                valor.ToString(
                    "E04",
                    CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );
        }
    }
}