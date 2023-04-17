using System;

namespace ObtendoValoresDaData
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(2020, 10, 12, 13, 23, 14);
            
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }
    }
}