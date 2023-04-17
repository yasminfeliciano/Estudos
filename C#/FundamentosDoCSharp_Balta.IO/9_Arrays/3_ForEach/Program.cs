using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 1, 2, 3, 4, 5};
            meuArray[0] = 12;

            //Console.WriteLine(meuArray.Length);

            foreach(var item in meuArray)
            {
                Console.WriteLine(item);
            }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() {Id = 2579, Nome = "André"};

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }

        }
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}