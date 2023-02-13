using System;

//A ordem de execução é primeiro o construtor da classe Base, depois o construtor da classe Derivada1 e depois o construtor da classe Derivada2.

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info()    //virtual significa que o método pode ser sobrescrito por outro
    {
        Console.WriteLine("Base");
    }
}

class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    override public void info()     //override significa que o método existe na classe base(Base) e está sendo sobrescrevendo o método anterior
    {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }

    override public void info()     //override significa que o método existe na classe base(Derivada1) e está sendo sobrescrevendo o método anterior
    {
        Console.WriteLine("Derivada 2");
    }
}

class Aula38
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Ref = derivada2;
        Ref.info();
    }
}