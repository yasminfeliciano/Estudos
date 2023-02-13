using System;

namespace Calc1     //namespace é um método de controlar, organizar o escopo. Pode-se classificar os elementos dentro do namespace.
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if(bas == 0| alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas*alt;
        }
    }
}

namespace Calc2
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if(bas == 0| alt == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas*alt;
        }
    }
}

class Aula54
{
    static void Main()
    {
        float area = 0;

        try
        {
            area = Calc1.Area.Quad(10f, 5f);
            Console.WriteLine("Area do quad.: {0}", area);
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }

    }
}