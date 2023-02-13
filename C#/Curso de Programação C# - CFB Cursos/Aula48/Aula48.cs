using System;

class Calc  //Recursividade é quando uma função chama ela mesma, é importante colocar um controle de parada para não gerar um loop infinito.
{
    public int soma(params int[]n)
    {
        int s = 0;
        for(int i=0; i<n.Length;i++)
        {
            s+=n[i];
        }
        return s;
    }

    public double soma(params double[]n)
    {
        double s = 0;
        for(int i=0; i<n.Length;i++)
        {
            s+=n[i];
        }
        return s;
    }

    public int fat(int n)
    {
        int res;
        if(n<=1)
        {
            res = 1;
        }
        else
        {
            res = n*fat(n-1);
        }

        return res;
    }
}

class Aula48
{
    static void Main()
    {
        Calc calc = new Calc();

        var res = calc.fat(5);

        Console.WriteLine(res);
    }
}