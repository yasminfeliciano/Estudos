using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO ====================================
            // 1. Crie um algoritmo que lê o nome de uma pessoa e escreva "Olá" seguido do nome da pessoa.

            //ESTRUTURA DADOS ==============================
            string nome;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 1 - STRING APARECER NA TELA=====");

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome);



            //ENUNCIADO ====================================
            //2. Crie um algoritmo que após ler dois números inteiros apresenta sua soma.

            //ESTRUTURA DADOS ==============================
            int a1, a2;
            int soma;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 2 - SOMA=====");

            Console.WriteLine("Insira o primeiro número");
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            a2 = int.Parse(Console.ReadLine());

            soma = a1 + a2;

            Console.WriteLine("A soma de " + a1 + " com " + a2 + " é: " + soma);
            Console.WriteLine("A soma de " + a1 + " com " + a2 + " é: " + (a1+a2));



            //ENUNCIADO ====================================
            //3. Crie um agopritmo que após ler dois números inteiros apresenta sua diferença.

            //ESTRUTURA DADOS ==============================
            int b1, b2;
            int dif;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 3 - DIFERENÇA=====");

            Console.WriteLine("Insira o primeiro número");
            b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            b2 = int.Parse(Console.ReadLine());

            dif = b1 - b2;

            Console.WriteLine("A diferença entre " + b1 + " e " + b2 + " é: " + dif);
            Console.WriteLine("A diferença entre " + b1 + " e " + b2 + " é: " + (b1 - b2));
            
            
            
            //ENUNCIADO ====================================
            //4. Pretende-se lendo a base e altura de um triângulo calcular a sua área.
            //area = base * altura

            //ESTRUTURA DADOS ==============================

            double Base, altura, area;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 4 - ÁREA DE UM TRIÂNGULO=====");

            Console.WriteLine("Qual o valor da base?");
            Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura?");
            altura = double.Parse(Console.ReadLine());

            area = Base * altura / 2;
            Console.WriteLine("A área do triângulo é: " + area);



            //ENUNCIADO ====================================
            //5. Faça um programa que receba um valor que é o valor pago, um segundo valor que é o preço do produto e retorne o troco a ser dado.

            //ESTRUTURA DADOS ==============================
            double vPago, preco, troco;
            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 5 - CALCULAR O TROCO=====");
            
            Console.WriteLine("Qual o preço do produto?");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor pago?");
            vPago = double.Parse(Console.ReadLine());

            troco = vPago - preco;

            if (troco > 0)
            {
                Console.WriteLine("O troco é: " + troco);
            }
            else if (troco < 0)
            {
                Console.WriteLine("Ainda falta pagar: " + Math.Abs(troco));
            }
            else
            {
                Console.WriteLine("}Não há troco");
            }



            //ENUNCIADO ====================================
            //6. Faça um programa que receba o valor do quilo de um produto e a quantidade de quilos do produto consumida calculando o valor final a ser pago.
            //ESTRUTURA DADOS ==============================
            double pKg, quantidade, vAPagar;
            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 6 - CALCULAR O CONSUMO POR KG DE UM PRODUTO=====");

            Console.WriteLine("Qual o preço do Kg do Produto?");
            pKg = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos Kg comprou?");
            quantidade = double.Parse(Console.ReadLine());

            vAPagar = pKg * quantidade;

            Console.WriteLine("O valor a pagar é: " + vAPagar);



            //ENUNCIADO ====================================
            //7. Faça um programa que receba 2 valores e retorne o maior entre eles.
            //ESTRUTURA DADOS ==============================
            int c1, c2;
            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 7 - RETORNAR O MAIOR VALOR ENTRE DOIS NÚMEROS=====");

            Console.WriteLine("Insira o primeiro número");
            c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo número");
            c2 = int.Parse(Console.ReadLine());

            if (c1 > c2)
            {
                Console.WriteLine("O maior é o: " + c1);
            }
            else if (c1 < c2)
            {
                Console.WriteLine("O maior é o: " + c2);
            }
            else
            {
                Console.WriteLine("São ambos iguais " + c1);
            }



            //ENUNCIADO ====================================
            //8. Faça um programa que receba 4 valores e retorne o menor entre eles.
            //ESTRUTURA DADOS ==============================
            int d1, d2, d3, d4;
            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 8 - RETORNAR O MENOR VALOR ENTRE QUATRO NÚMEROS=====");

            Console.WriteLine("Insira o 1º número");
            d1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2º número");
            d2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 3º número");
            d3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 4º número");
            d4 = int.Parse(Console.ReadLine());

            if(d1<d2 && d1<d3 && d1<d4)
            {
                Console.WriteLine("O menor é o: " + d1);
            }
            else if(d2<d3 && d2<d4)
            {
                Console.WriteLine("O menor é o: " + d2);
            }
            else if (d3 < d4)
            {
                Console.WriteLine("O menor é o: " + d3);
            }
            else
            {
                Console.WriteLine("O menor é o: " + d4);
            }



            //ENUNCIADO ====================================
            //9. Faça um programa que verifique se um número é ímpar

            //ESTRUTURA DADOS ==============================
            int num;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 9 - VERIFICAR SE O NÚMERO É PAR=====");

            Console.WriteLine("Insira um número");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }



            //ENUNCIADO ====================================
            //10. Faça um programa que receba 3 valores que representarão os lados de um triângulo e verifique se os valores formam um triângulo e classifique esse triângulo como:
            //a. Equilátero (3 lados iguais);
            //b. Isóceles (2 lados iguais);
            //c. Escaleno (3 lados diferentes);
            //De notar que para formar um triângulo:
            //a. Nenhum dos lados pode ser igual a zero;
            //b. Um lado não pode ser maior do que a soma dos outros dois;

            //ESTRUTURA DADOS ==============================
            int l1, l2, l3;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 10 - VERIFICAR SE O EXISTE E, SE SIM, DE QUE TIPO ELE É====="); 

            Console.WriteLine("Qual o valor do lado 1");
            l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 2");
            l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do lado 3");
            l3 = int.Parse(Console.ReadLine());

            if(l1==0 || l2==0 || l3 == 0)
            {
                Console.WriteLine("O triângulo é impossível, porque pelo menos um dos lados é 0");
            }
            else if(l1>l2+l3 || l2>l1+l3 || l3>l1+l2)
            {
                Console.WriteLine("O triângulo é impossível, porque pelo menos um dos lados é maior que a soma dos outros dois.");
            }
            else  //Triângulo possível
            {
                if(l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Triângulo Equilátero!");
                }
                else if (l1!=l2 && l1!=l3 && l2!=l3)
                {
                    Console.WriteLine("Triângulo Escaleno!");
                }
                else if ((l1==l2 && l1!=l3) || (l1==l3 && l1!=l2) || (l2==l3 && l2!=l1))
                {
                    Console.WriteLine("Triângulo Isóceles!");
                }
            }



            //ENUNCIADO ====================================

            //ESTRUTURA DADOS ==============================

            //ALGORITMO ====================================



            //ENUNCIADO ====================================

            //ESTRUTURA DADOS ==============================

            //ALGORITMO ====================================
        }
    }
}