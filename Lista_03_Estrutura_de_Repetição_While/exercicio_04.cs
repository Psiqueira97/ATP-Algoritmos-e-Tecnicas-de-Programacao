/*04. Escreva um programa que leia um número inteiro n. Em seguida, leia a idade de n pessoas, calcule e imprima (a) a
quantidade de pessoas em cada faixa etária e (b) a porcentagem de cada faixa etária em relação ao total de pessoas.
Faixas etárias:
• 1 a 15 anos
• 16 a 30 anos
• 31 a 45 anos
• 46 a 60 anos
• ≥ 61 anos*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 1, idade;
            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, fInvalida = 0;

            Console.Write("Você digitará a idade de quantas pessoas?\nDigite: ");
            n = int.Parse(Console.ReadLine());

            while (cont <= n)
            {
                Console.Write("Digite a idade da " + cont + "ª pessoa: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    fInvalida++;
                }
                else if (idade <= 15)
                {
                    f1++;
                }
                else if (idade <= 30)
                {
                    f2++;
                }
                else if (idade <= 45)
                {
                    f3++;
                }
                else if (idade <= 60)
                {
                    f4++;
                }
                else
                {
                    f5++;
                }

                cont++;
            }

            Console.WriteLine("\n\nRESULTADO:\n");

            if (fInvalida > 0)
            {
                Console.WriteLine(fInvalida + " registros inválidos (" + ((double)fInvalida / n * 100).ToString("F2") + "%)\n");
            }

            Console.WriteLine("1 a 15 anos: " + f1 + " pessoas (" + ((double)f1 / n * 100).ToString("F2") + "%)");
            Console.WriteLine("16 a 30 anos: " + f2 + " pessoas (" + ((double)f2 / n * 100).ToString("F2") + "%)");
            Console.WriteLine("31 a 45 anos: " + f3 + " pessoas (" + ((double)f3 / n * 100).ToString("F2") + "%)");
            Console.WriteLine("46 a 60 anos: " + f4 + " pessoas (" + ((double)f4 / n * 100).ToString("F2") + "%)");
            Console.WriteLine(">= 61 anos: " + f5 + " pessoas (" + ((double)f5 / n * 100).ToString("F2") + "%)");

            Console.ReadLine();
        }
    }
}