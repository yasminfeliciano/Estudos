using System;

class Aula04
{
    static int num=0; //Precisa ser static pois o método onde ela está sendo utilizada é static.
    static void Main()
    {
        int num2=0; //*
        Console.WriteLine(num);
    }

    void teste()
    {
        int num2=0; //* Por serem variáveis locais só são válidas para escopos locais, portando podem ser atribuídas mais de uma vez dentro da classe
        Console.WriteLine(num);
    }
}