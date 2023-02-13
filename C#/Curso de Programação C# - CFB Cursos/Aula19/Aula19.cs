using System;

class Aula19
{
    static void Main()
    {
        int [] num = new int[10];
        for(int i = 0; i < num.Length; i++)
        {
            num[i] = i;
        }

        for(int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("valor de num na pos{0}: {1}", i, num[i]);
        }
    }
}