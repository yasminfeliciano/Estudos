using System;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //Cria um id novo com o guid
            id.ToString();
            
            id = new Guid("0438d5f7-5994-48e8-b9ca-e24737dd93bd");
            if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0,8));

            /*
            id = new Guid(); //inicializa o guid com tudo zerado "00000000-0000-0000-0000-000000000000"
            Console.WriteLine(id);
            */
        }
    }
}
