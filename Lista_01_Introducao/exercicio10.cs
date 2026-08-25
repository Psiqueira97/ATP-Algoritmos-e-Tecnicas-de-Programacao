/*10. Escreva um programa que leia um número inteiro com três dígitos (no formato CDU - centena,
dezena e unidade) e mostre o número invertido (no formato UDC). Dica: use os operadores de
divisão e resto. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CDU, C, D, U;

            Console.Write("Digite o número inteiro com três dígitos (no formato CDU): ");
            CDU = int.Parse(Console.ReadLine());

            U = CDU % 10;
            C = CDU / 10;
            D = C % 10;
            C = C / 10;

            Console.WriteLine("\nO número invertido é:");
            Console.Write(U);
            Console.Write(D);
            Console.Write(C);

            Console.ReadLine();
        }
    }
}
