using System;
using System.Collections.Generic;

class Aula57
{
    static void Main()
    {
        List<string>carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);
        
        //carros.Clear()

        if(carros.Contains("Golf"))
        {
            Console.WriteLine("Está na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2);

        foreach(string c in carros)
        {
            Console.WriteLine("Carro: {0}",c);
        }

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca);
        Console.WriteLine("Carro {0} está na posição {1}", ca, pos);
    }
}