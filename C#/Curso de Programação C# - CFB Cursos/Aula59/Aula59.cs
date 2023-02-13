using System;
using System.Collections.Generic;

class Aula59
{
    static void Main()
    {
        //string[] vs = {"Carro", "Moto", "Navio", "Avião"};
        Queue<string>veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";
        if(veiculos.Contains(v))
        {
            Console.WriteLine("Veiculo "+ v +" encontrado");
        }
        else
        {
            Console.WriteLine("Veiculo "+ v +" não está na fila");
        }

        //veiculos.Clear();

        //Console.WriteLine("Primeiro Veiculo e remover"+ veiculos.Dequeue);  Retorna o primeiro elemento e o remove.
        
        //Console.WriteLine("Primeiro Veiculo"+ veiculos.Peek);   Retorna o primeiro elemento e não o remove.

        foreach(string veic in veiculos)
        {
            veic=veiculos.Dequeue();
            Console.WriteLine("Veiculo removido: "+ veic);
        }

        foreach(string veic2 in veiculos)
        {
            Console.WriteLine("Veiculo "+ veic2);
        }

        Console.WriteLine("Tamanho fila:"+veiculos.Count);

        while(veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }

        Console.WriteLine("Tamanho fila: "+ veiculos.Count);
    }
}