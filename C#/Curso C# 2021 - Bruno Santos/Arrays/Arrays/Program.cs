using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        //Variavel do exercício 5
        static int[] numerosInv;
        static Random rndInv;

        static void Main(string[] args)
        {
            string nome1 = "Ana Silva";
            string nome2 = "José Martins";
            string nome3 = "Afonso Teixeira";
            string nome4 = "Maria Gomes";
            string nome5 = "Sofia Costa";

            Console.WriteLine("Nome 1: " + nome1);
            Console.WriteLine("Nome 2: " + nome2);
            Console.WriteLine("Nome 3: " + nome3);
            Console.WriteLine("Nome 4: " + nome4);
            Console.WriteLine("Nome 5: " + nome5);

            Console.WriteLine("-------------------------------------");

            string[] nomes = new string[] { "Ana", "José", "Afonso", "Maria", "Sofia"};

            string[] sobrenomes = new string[5];
            sobrenomes[0] = "Silva";
            sobrenomes[1] = "Martins";
            sobrenomes[2] = "Teixeira";
            sobrenomes[3] = "Gomes";
            sobrenomes[4] = "Costa";

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome " + (i + 1) + ": " + nomes[i] + " " + sobrenomes[i]);
            }

            Random rnd = new Random();
            
            int[] numeros = new int[50];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 100);
                Console.Write(numeros[i] + " ");
            }

            double[] decimais = new double[10];
            bool[] verdadeirosFalsos = new bool[10];

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");

            int[,] tabuada = new int[10, 10];

            for(int i = 0; i< 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabuada[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabuada[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //ENUNCIADO ====================================
            //1. Faça um programa que peça ao utilizador três notas, guarde-as num vetor e apresente a média final lendo as notas do vetor.

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO ARRAYS 1 - MÉDIA DAS NOTAS=====");


            double[] notas = new double[3];

            for(int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Insira a " + (i + 1) + "ª nota");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            Console.WriteLine("A média é: "+(soma / notas.Length));



            //ENUNCIADO ====================================
            //2. Faça um programa que guarde num vetor os nomes de pelo menos 10 alunos da turma. Deve permitir ao utilizador ao inserir o número do aluno (índice do vetor) indicar qual o nome do mesmo.

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO ARRAYS 2 - NOME DOS ALUNOS=====");

            string[] nomesA = new string[10];

            for(int i = 0; i < nomesA.Length; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "º nome");
                nomesA[i] = Console.ReadLine();
            }

            Console.WriteLine("Qual a posição que quer ver?");
            int posA = int.Parse(Console.ReadLine()) - 1;

            if(posA >= 0 && posA < nomesA.Length)
            {
                Console.WriteLine(nomesA[posA]);
            }
            else
            {
                Console.WriteLine("Nome inexistente");
            }



            //ENUNCIADO ====================================
            //3. Faça um programa que receba 10 valores inteiros e os coloque em um vetor. Em seguida exiba-os em ordem inversa à ordem de entrada.

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO ARRAYS 3 - INVERTER A ORDEM DOS NÚMEROS=====");

            int[] numerosOrd = new int[10];
            Random rndOrd = new Random();

            for (int i = 0; i< numerosOrd.Length; i++)
            {
                numerosOrd[i] = rndOrd.Next(1, 100);
            }

            Console.WriteLine("Ordem de inserção");
            for(int i = 0; i < numerosOrd.Length; i++)
            {
                Console.WriteLine("Posição: " + i + "\tValor: " + numerosOrd[i]);
            }

            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("Ordem inversa:");
            for (int i = numerosOrd.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Posição: " + i + "\tValor: " + numerosOrd[i]);
            }



            //ENUNCIADO ====================================
            //4. Faça um programa que utilize uma estrutura de repetição para ler 50 números armazenando-os em um vetor e calcule e exiba a média aritmética deles. Em seguida o programa deve apresentar todos os valores armazenados no vetor que sejam menores que a média.

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO ARRAYS 4 - MÉDIA DOS NÚMEROS E EXIBIÇÃO DOS NÚMEROS MENORES QUE 50=====");

            Random rndMed = new Random();
            double[] numerosMed = new double[50];
            double somaMed = 0, mediaMed;

            for (int i = 0; i < numerosMed.Length; i++)
            {
                numerosMed[i] = rndMed.Next(1, 100);
                somaMed += numerosMed[i];
            }

            mediaMed = somaMed / numerosMed.Length;

            for(int i = 0; i< numerosMed.Length; i++)
            {
                if (numerosMed[i] < mediaMed)
                {
                    Console.WriteLine("Posição: " + i + "\tValor: " + numerosMed[i]);
                }
            }



            //ENUNCIADO ====================================
            //5. Faça um programa que ordene de forma crescente e decrescente um vetor. Sugere-se pesquisa na internet pelo tópico: "c# bubble sort".

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO ARRAYS 5 - INVERTER A ORDEM DOS NÚMEROS=====");

            numerosInv = new int[10];
            rndInv = new Random();


            //Preenchimento do array com números aleatórios
            Preencher();

            //Imprimir sem ordenação
            Console.WriteLine("----- ORDEM INICIAL -----");
            Imprimir();

            //Imprimir ordenado crecente
            Console.WriteLine("----- ORDEM CRESCENTE -----");
            OrdenarCrescente();
            Imprimir();

            //Imprimir ordenado descrescente
            Console.WriteLine("----- ORDEM DECRESCENTE -----");
            OrdenarDecrescente();
            Imprimir();
        }

        private static void Preencher()
        {
            for (int i = 0; i < numerosInv.Length; i++)
            {
                numerosInv[i] = rndInv.Next(1, 100);
            }
        }

        private static void OrdenarCrescente()
        {
            for (int i = 0; i < numerosInv.Length - 1; i++)
            {
                for (int j = i+1; j < numerosInv.Length; j++)
                {
                    if (numerosInv[i] > numerosInv[j])
                    {
                        int aux = numerosInv[i];
                        numerosInv[i] = numerosInv[j];
                        numerosInv[j] = aux;
                    }
                }
            }
        }

        private static void OrdenarDecrescente()
        {
            for (int i = 0; i < numerosInv.Length - 1; i++)
            {
                for (int j = i + 1; j < numerosInv.Length; j++)
                {
                    if (numerosInv[i] < numerosInv[j])
                    {
                        int aux = numerosInv[i];
                        numerosInv[i] = numerosInv[j];
                        numerosInv[j] = aux;
                    }
                }
            }
        }

        private static void Imprimir()
        {
            for (int i = 0; i < numerosInv.Length; i++)
            {
                Console.WriteLine("Posição: " + i + "\tValor: " + numerosInv[i]);
            }

            Console.WriteLine();
        }
    }
}
