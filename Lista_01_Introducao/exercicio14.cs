/*14. Desenvolver um algoritmo ou programa em C# que leia um número inteiro e verifique se o
número é divisível por 5 e por 3 ao mesmo tempo.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            
            Console.Write("Digite o número para saber se é multiplo comum 5 e 3: ");
            num = double.Parse(Console.ReadLine());
            
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("\n" + num + " é múltiplo comum de 5 e 3.");
            }
            else
            {
                Console.WriteLine("\n" + num + " NÃO é múltiplo comum de 5 e 3.");
            }

            Console.ReadLine();
        }
    }
}
