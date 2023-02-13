using System;

class Aula10
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo;
        Console.WriteLine(ds);

        DiasSemana ds2 = (DiasSemana)3; 
        Console.WriteLine(ds2);

        int ds3 = DiasSemana.Sexta;
        Console.WriteLine(ds3);
    }
}
