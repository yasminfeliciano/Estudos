using System;

namespace AdicionandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            Console.WriteLine(data);
            
            Console.WriteLine(data.AddDays(12));

            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));

            Console.WriteLine(data.AddHours(2));

            Console.WriteLine(data.AddMinutes(15));

        }
    }
}