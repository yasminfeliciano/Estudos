using System;

class Aula17
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;
        int[] n = new int[5]; //0-4

        n[0] = 11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;
        Console.WriteLine(n[4]);

//--------------------------------------

        int[] num = new int[3]{55,77,99}; //Quantidade de elementos declarada

        Console.WriteLine(num[2]);
//--------------------------------------

        int[] num = {55,77,99,66,88}; //Quantidfade de elementos não declarada, se entende pela quantidade de elementos existentes

        Console.WriteLine(num[4]);
//--------------------------------------

        string[] veiculos = new string[3];

        veiculos[0] = "Carro";
        veiculos[1] = "Avião";
        veiculos[2] = "Navio";

        Console.WriteLine(num[2]);
    }
}