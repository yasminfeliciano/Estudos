using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDotNetCursoCSharp_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            var nomeCorrentista = "Ray Carneiro";
            nomeCorrentista = Console.ReadLine();
            Console.Write("Nome da variável:" + nomeCorrentista);
            Console.ReadLine();


            int xpto = Convert.ToInt32("10");


            var dataAniversario = Convert.ToDateTime("13/03/1987");


            double saldo = 100.0;
            saldo = saldo - 10.0;
            Console.Write("O seu saldo atual é: " + saldo);
            Console.ReadLine();


            //ARRAYS

            String[] nomes = new String[] { "Fulano da Silva", "Beltrano da Silva" };
            Console.Write("O valor da posição é: " + nomes[0]);
            Console.Read();

            //Constante
            const double Pi = 3.14159;
            double radius = 5.3;
            double area = Pi * (radius * radius);

            Console.Write("O valor da área é: " + area);
            Console.ReadLine();

            //List
            List<String> nomes2 = new List<String>();
            nomes2.Add("Fulano da Silva");
            nomes2.Add("Beltrano da Silva");
            nomes2.Add("Ray");

            Console.Write("Posição inicial da lista: " + nomes2[0]+ ", com o tamanho de lista: "+nomes2.Count());
            Console.Read();

            bool existeNaLista = nomes2.Contains("Ray");

            Console.Write("Existe na lista? " + existeNaLista);
            Console.Read();

            //Enum
            var diaDaSemana1 = DiasDaSemana.SegundaFeira;
            int diaDaSemana2 = (int)DiasDaSemana.SegundaFeira;
            int diaDaSemana3 = Convert.ToInt32(DiasDaSemana.SegundaFeira);



            Console.Write("Hoje é dia: " + diaDaSemana1);
            Console.Write("Hoje é dia: " + diaDaSemana2);
            Console.Write("Hoje é dia: " + diaDaSemana3);

            Console.Read();

            //For
            int tamanho = 10;
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("O valor da variável i é: " + i + "\n");
            }
            Console.ReadKey();

            //If Else

            double saldoConta = 100.0;
            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar = Convert.ToDouble(Console.ReadLine());

            saldoConta = saldoConta - debitar;

            if (saldoConta > 0)
            {
                Console.Write("Seu saldo é positivo. Ainda restam {0} em conta", saldoConta);
            }
            else
            {
                Console.Write("Seu saldo é negativo.");
            }

            //Foreach
            List<String> nomes3 = new List<String> { "Ray Carneiro", "Pollyanna Carneiro", "Fernando Mendes" };

            foreach( var item in nomes3)
            {
                Console.Write("O nome da pessoa é: " + item);
            }

            Console.ReadKey();

            //Switch
            double saldoConta2 = 100.00;
            Console.Write("Digite um valor para debitar da sua conta: ");
            var debitar2 = Convert.ToDouble(Console.ReadLine());

            saldoConta2 = saldoConta2 - debitar2;

            switch (saldoConta2)
            {
                case 50.00:
                    Console.Write("Você debitou 50 da sua conta");
                    break;

                case 10.00:
                    Console.Write("Você debitou 90 da sua conta");
                    break;

                default:
                    Console.Write("Você debitou {0} da sua conta", debitar2);
                    break;
            }

            //Classe e objeto
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Ray Carneiro";
            pessoa1.CPF = "123456789";
            pessoa1.NumeroContaCorrente = "010203";

            //Region
            //Tudo oque eu escrever aqui é algo específico dessa região
            #region Região de Depósito

            double valorDoDeposito = 50.0;
            Console.Write("O saldo da conta é de: " + pessoa1.EfetuarDeposito(valorDoDeposito));
            Console.ReadKey();

            #endregion

            Pessoa pessoa2 = new Pessoa()
            {
                Nome = "Fulano da Silva",
                CPF = "123456789",
                NumeroContaCorrente = "030201"
            };

            List<Pessoa> ListaDePessoas = new List<Pessoa>();
            ListaDePessoas.Add(pessoa1);
            ListaDePessoas.Add(pessoa2);

            foreach (var pessoa in ListaDePessoas)
            {
                Console.Write("Nome da pessoa: " + pessoa.Nome);
            }

            Console.ReadKey();

        }

        //Enum
        enum DiasDaSemana
        {
            Domingo = 0,
            SegundaFeira = 1,
            TerçaFeira = 2,
            QuartaFeira = 3,
            QuintaFeira = 4,
            SextaFeira = 5,
            Sabado = 6
        };
    }
}
