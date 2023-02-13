using System;

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

class Aula53
{
    static void Main()
    {
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 2;

        try
        {
            res = n1/n2;
            Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            throw new Exception("CFB Cursos");
        }
        catch(Exception e)
        {
            Console.WriteLine("ERRO: {0}", e.Message);
            Console.WriteLine("Ex: {0}", e.GetType());
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }

        Console.WriteLine("---------------------------");

        float area = 0;

        try
        {
            area = Area.Quad(10f, 5f);
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