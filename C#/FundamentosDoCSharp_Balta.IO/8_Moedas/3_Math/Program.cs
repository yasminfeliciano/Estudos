using System;

namespace MathMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            Console.WriteLine(
                Math.Round(valor)
            );

            Console.WriteLine(
                Math.Ceiling(valor)
            );

            Console.WriteLine(
                Math.Floor(valor)
            );
        }
    }
}