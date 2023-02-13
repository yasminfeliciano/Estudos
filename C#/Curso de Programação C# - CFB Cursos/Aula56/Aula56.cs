using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");
        
        LinkedListNode<string>no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");
        no = transp.FindLast("Carro");
        transp.AddBefore(no,"Patins");

        //transp.Clear();
        
        if(transp.Find("Carro")==null)
        {
            Console.WriteLine("Não encontrado");
        }
        else
        {
            Console.WriteLine("Elemento encontrado");
        }

        transp.Remove("Navio");
        //transp.RemoveFirst();
        //transp.RemoveLast();
        //transp.FindLast("Navio").Next;
        //transp.FindLast("Navio").Value;

        foreach(string t in transp)
        {
            Console.WriteLine("Transporte: {0}", t);
        }

        
    }
}