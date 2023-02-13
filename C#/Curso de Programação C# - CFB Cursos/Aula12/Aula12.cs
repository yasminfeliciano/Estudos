using System;

class Aula12
{
    static void Main()
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado = "Reprovado";

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        nota = int.Parse(Console.ReadLine());

        if(res>=60)
        {
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {} = Resultado: {0}", res,  resultado);
    }
}