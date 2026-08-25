/*04.Faça um programa que leia um número e informe se ele é divisível por 3 e também por 5 (Exemplo: 15
é divisível por 3 e por 5).*/

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
            int num;

            Console.Write("Digite um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("\nO número " + num + " é multiplo comum de 3 e 5.");
            }
            else
            {
                Console.WriteLine("\nO número " + num + " NÃO é multiplo comum de 3 e 5.");
            }

            Console.ReadLine();
        }
    }
}
