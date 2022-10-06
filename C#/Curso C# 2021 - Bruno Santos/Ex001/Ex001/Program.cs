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
            //11. Utilize a estrutura SE para fazer um programa que retorne o nome de um produto a partir do código do mesmo. Considere os seguintes códigos:
            //a. 001 - Parafuso;
            //b. 002 - Porca;
            //c. 003 - Prego;
            //d. 004 - Para qualquer outro código indicar "Não definido".

            //ESTRUTURA DADOS ==============================
            int codIf;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 11 - ASSOCIAR O CÓDIGO AO PRODUTO=====");

            Console.WriteLine("Insira o código do produto");

            codIf = int.Parse(Console.ReadLine());

            if (codIf == 1)
            {
                Console.WriteLine("001 - Parafuso");
            }
            else if (codIf == 2)
            {
                Console.WriteLine("002 - Porca");
            }
            else if (codIf == 3)
            {
                Console.WriteLine("003 - Prego");
            }
            else
            {
                Console.WriteLine("Não definido");
            }



            //ENUNCIADO ====================================
            //12. Refaça o exercício anterior usando a estrutura LER-CASO.

            //ESTRUTURA DADOS ==============================
            int codCase;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 12 - ASSOCIAR O CÓDIGO AO PRODUTO USANDO LER-CASO=====");

            Console.WriteLine("Insira o código do produto");

            codCase = int.Parse(Console.ReadLine());

            switch(codCase)
            {
                case 1:
                    Console.WriteLine("001 - Parafuso");
                    break;
                case 2:
                    Console.WriteLine("002 - Porca");
                    break;
                case 3:
                    Console.WriteLine("003 - Prego");
                    break;
                default:
                    Console.WriteLine("Não definido");
                    break;
            }



            //ENUNCIADO ====================================
            //13. Faça um programa que utilize a estrutura ENQUANTO para ler 50 números e calcule e exiba a média aritmética deles.

            //ESTRUTURA DADOS ==============================
            double numEnq, somaEnq = 0, mediaEnq, iEnq = 1, numTotalEnq = 5;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 13 - ESTRUTURA ENQUANTO=====");

            while (iEnq<= 5)
            {
                Console.WriteLine("Insira um número");
                numEnq = double.Parse(Console.ReadLine());

                somaEnq += numEnq;
                iEnq++;
            }

            mediaEnq = somaEnq / numTotalEnq;

            Console.WriteLine("A média dos números inseridos é: " + mediaEnq);



            //ENUNCIADO ====================================
            //14. Refaça o exercício usando a estrutura PARA.

            //ESTRUTURA DADOS ==============================
            double numPara, somaPara= 0, mediaPara, /*iPara = 1,*/ numTotalPAra = 5;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 14 - ESTRUTURA FOR=====");
            
            for (int iPara = 1; iPara <= numTotalPAra; iPara++)
            {
                Console.WriteLine("Insira " + iPara + "º número");
                numPara = double.Parse(Console.ReadLine());

                somaPara += numPara;
            }



            //ENUNCIADO ====================================
            //15. O preço de um automóvel é calculado pela soma do preço de fábrica com o preço dos impostos (45% do preço de fábrica e a percentagem do revendedor (28% do preço de fábrica). Faça um algoritmo que leia o nome do automóvel e o preço de fábrica e escreva o nome do automóvel e o preço final.

            //ESTRUTURA DADOS ==============================
            double pFabrica, pImpostos, pRevendedor, pFinal;
            double percImpostos = 0.45, percRevendedor = 0.28;
            string nomeAutomovel;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 15 - PREÇO DO AUTOMÓVEL=====");

            Console.WriteLine("Qual o automóvel que irá comprar?");
            nomeAutomovel = Console.ReadLine();

            Console.WriteLine("Qual o preço de fábrica do automóvel?");
            pFabrica = double.Parse(Console.ReadLine());

            pImpostos = pFabrica * percImpostos;
            pRevendedor = pFabrica * percRevendedor;

            pFinal = pFabrica + pImpostos + pRevendedor;

            Console.WriteLine("O seu novo automóvel " + nomeAutomovel + " custará " + pFinal);



            //ENUNCIADO ====================================
            //16. Dado uma série de 20 valores inteiros, faça um algoritmo que calcule e escreva a média aritmética destes valores.

            //ESTRUTURA DADOS ==============================
            double numMed, somaMed = 0, mediaMed, numTotalMed = 5;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 16 - MÉDIA ARITMÉTICA=====");

            for(int iMed = 1; iMed <= numTotalMed ; iMed++)
            {
                Console.WriteLine("Insira o " + iMed + "º valor");
                numMed = double.Parse(Console.ReadLine());

                somaMed += numMed;
            }

            mediaMed = somaMed / numTotalMed;

            Console.WriteLine("A média é: " + mediaMed);



            //ENUNCIADO ====================================
            //17. Adapte o exercício anterior considerando que se a média obtida for maior que 8 deverá ser atribuida 10 para a média.

            //ESTRUTURA DADOS ==============================
            double numMedA, somaMedA = 0, mediaMedA, numTotalMedA = 5;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 17 - MÉDIA ARITMÉTICA ACRESCIDA DE 10=====");

            for (int iMedA = 1; iMedA <= numTotalMedA; iMedA++)
            {
                Console.WriteLine("Insira o " + iMedA + "º valor");
                numMedA = double.Parse(Console.ReadLine());

                somaMedA += numMedA;
            }

            mediaMedA = somaMedA / numTotalMedA;

            if (mediaMedA > 8)
            {
                Console.WriteLine("A média é 10");
            }
            else
            {
                Console.WriteLine("A média é " + mediaMedA);
            }



            //ENUNCIADO ====================================
            //18. Faça um algoritmo que leia 3 números inteiros e mostre o menor deles.

            //ESTRUTURA DADOS ==============================
            int e1, e2, e3;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 18 - MOSTRAR O MENOR NÚMERO=====");

            Console.WriteLine("Insira o 1º número");
            e1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 2º número");
            e2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o 3º número");
            e3 = int.Parse(Console.ReadLine());

            if (e1 < e2 && e1 < e3)
            {
                Console.WriteLine("O menor é o: " + e1);
            }
            else if (e2 < e3)
            {
                Console.WriteLine("O menor é o: " + e2);
            }
            else
            {
                Console.WriteLine("O menor é o: " + e3);
            }



            //ENUNCIADO ====================================
            //19. Dado um conjunto de n números inteiros inseridos pelo utilizador, faça um algoritmo que calcule a média dos valores maiores que 4.

            //ESTRUTURA DADOS ==============================
            double numVM, somaVM = 0, mediaVM, contVM = 0, opVM = 1;

            //ALGORITMO ====================================
            Console.WriteLine("=====EXERCÍCIO 19 - MÉDIA DOS VALORES MAIORES QUE 4=====");

            while (opVM != 0)
            {
                Console.WriteLine("Insira um número");
                numVM = double.Parse(Console.ReadLine());

                if (numVM > 4)
                {
                    somaVM += numVM;
                    contVM++;
                }
                Console.WriteLine("Pretende inserir um novo número?");

                Console.WriteLine("1 - Sim");
                Console.WriteLine("0 - Não");

                opVM = double.Parse(Console.ReadLine());
            }

                mediaVM = somaVM / contVM;

            if (contVM > 0)
            {
                Console.WriteLine("A média é " + mediaVM);
            }
            else
            {
                Console.WriteLine("Não foram inseridos valores superiores a 4");
            }

        }
    }
}