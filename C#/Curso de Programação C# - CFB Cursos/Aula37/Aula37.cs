using System;

//A ordem de execução é primeiro o construtor da classe Base, depois o construtor da classe Derivada1 e depois o construtor da classe Derivada2.

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }
}

class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }
}

class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }
}

class Aula37
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();
    }
}