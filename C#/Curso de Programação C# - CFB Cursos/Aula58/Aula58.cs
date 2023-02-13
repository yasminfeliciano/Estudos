using System;
using System.Collections.Generic;

class Aula58
{
    static void Main()
    {
        List<string>carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

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

        carros.Insert(1, "Cruze");

        //carros.Remove("Argo");
        //carros.RemoveAll();
        //carros.RemoveAt(0);
        
        carros.Reverse();
        foreach(string c in carros)
        {
            Console.WriteLine("Carro: {0}",c);
        }

        carros.Sort(); 
        foreach(string c in carros)
        {
            Console.WriteLine("Carro: {0}",c);
        }

        int tamanho = carros.Count;
        Console.WriteLine("Tamanho {0}",c);

        carros.Capacity = 15;
        int capa = carros.Capacity;

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca);
        Console.WriteLine("Carro {0} está na posição {1}", ca, pos);

        int pos2 = carros.LastIndexOf("HRV");
        Console.WriteLine("Ultimo HRV está na posição {0}",pos2);
    }
}