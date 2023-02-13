using System;

class Aula26
{
    static void Main()
    {
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 5;
        quoc = divite(divid, divis, out rest);
        Console.WriteLine("{0}/{1}:quociente={2} e resto={3}", divid, divis, quoc,rest);
    }

    static int divite(int dividendo, int divisor)
    {
        int quociente;
        quociente = dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;
    }
}