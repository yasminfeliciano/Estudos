using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CriacaoDeObjetoEConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ana";
            Pessoa p2 = new Pessoa("Ana", "Rua 123", 20, "ana@email.pt");
            Pessoa p3 = new Pessoa(p2);
            //p3.Nome = "João";

            Console.WriteLine(p2.Email);
            Console.WriteLine("--------------------------");
            Console.WriteLine(p1.ToString());
            Console.WriteLine("--------------------------");
            Console.WriteLine(p2.ToString());
            Console.WriteLine("--------------HASH 1------------");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine("--------------HASH 2------------");
            Console.WriteLine(p2.GetHashCode()); 
            Console.WriteLine("--------------HASH 3------------");
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p1));
            Console.WriteLine(p2.Equals(p3));
        }
    }
}
