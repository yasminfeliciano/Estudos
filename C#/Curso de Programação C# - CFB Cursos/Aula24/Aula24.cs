using System;

class Aula24
{
    static void Main()
    {
        int v1, v2; //Soma
        int u1, u2, r; //Subtração

        for(int i = 0; i<10;i++)
        {
            Ola();
        }

        cfb();

        //Soma
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1, v2);

        //Subtração
        u1 = Convert.ToInt32(Console.ReadLine());
        u2 = Convert.ToInt32(Console.ReadLine());
        r = subtracao(u1, u2);
        Console.WriteLine("A subtração entre {0} e {1} é: {2}", u1, u2, r);
        Console.WriteLine("A subtração entre {0} e {1} é: {2}", u1, u2, subtracao(u1,u2));
    }

    static void Ola()
    {
        Console.WriteLine("Olá!!!");
    }

    static void cfb()
    {
        Console.WriteLine("CFD Cursos");
        Console.WriteLine("Curso de C#");
        Console.WriteLine("youtube.com/cfbcursos");
    }

    //Soma
    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }

    //Subtração
    static int subtracao(int m1, int m2)
    {
        int result = m1 + m2;
        return result;
    }
}
