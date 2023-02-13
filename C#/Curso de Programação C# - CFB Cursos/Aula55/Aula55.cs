using System;
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear();

        //veiculos.Remove(20);

        //veiculos[15] = "Bicicleta";


        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        int chave = 20;

        if(veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A chave {0} está na coleção", chave);
        }
        else
        {
            Console.WriteLine("A chave {0} não está na coleção");
        }

        string valor = "Navio";

        if(veiculos.ContainsKey(valor))
        {
            Console.WriteLine("O valor {0} está na coleção", valor);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção", valor);
        }

        foreach(KeyValuePair<int, string> v in veiculos)
        {
            Conosle.WriteLine(v.Value);
        }
        
        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach(string v in valores)
        {
            Conosle.WriteLine(v);
        }
    }
}