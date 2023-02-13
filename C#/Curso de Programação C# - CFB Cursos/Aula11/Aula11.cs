using System;

class Aula11
{
    static void Main()
    {
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2);

//-----------------------------------

        int n3 = 10.5f;
        float n4 = (int)n3; //Type cast

        Console.WriteLine(n4);

//-----------------------------------

        int vInt = 10;
        long vLong = vInt;
        long vShort = (int)vInt;


        Console.WriteLine(vLong);
        Console.WriteLine(vShort);


    } 
}