using System;

class Mat   //As variáveis statics da classe Mat podem ser acessadas em qualquer lugar e não precisam ser declaradas para isso.
{
    public static double pi=3.14;

    public static dobro(int n)
    {
        return n*2;
    }
}

class Aula49
{
    static void Main()
    {
        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));
    }
}