/*01. Escreva um programa que leia um número inteiro entre 0 e 5 e imprima o valor lido por extenso (ex:
“Cinco”), se o número estiver fora dessa faixa imprima “Valor inválido”*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite um número (entre 0 e 5): ");

            n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("\nZero");
            }
            else if (n == 1)
            {
                Console.WriteLine("\nUM");
            }
            else if (n == 2)
            {
                Console.WriteLine("\nDOIS");
            }
            else if (n == 3)
            {
                Console.WriteLine("\nTRÊS");
            }
            else if (n == 4)
            {
                Console.WriteLine("\nQUATRO");
            }
            else if (n == 5)
            {
                Console.WriteLine("\nCINCO");
            }
            else
            {
                Console.WriteLine("\nVALOR INVÁLIDO");
            }

            Console.ReadLine();
        }
    }
}
