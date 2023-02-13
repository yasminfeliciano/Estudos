using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome=n;
    }

    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
}

class Aula29
{
    static void Main()
    {
        string nome1;
        Console.WriteLine("digite o nome do jogador 3");
        nome1=Console.ReadLine();

        Jogador j1 = new Jogador("Bruno");
        Jogador j2 = new Jogador("Victor");
        Jogador j3 = new Jogador(nome1);

        j1.energia = 50;
        
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
        Console.WriteLine("Nome do jogador 3: {0}", j3.nome);
    }
}