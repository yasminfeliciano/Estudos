using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            for(var index = 0; index < 10; index++)
            {
                Console.WriteLine(arr[index]);
            }
        }
    }
}