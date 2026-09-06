/*08. Desenvolva um programa que imprima os n primeiros elementos da sequência de Fibonacci.
Ex.: Se n = 10, imprimir os 10 primeiros números da sequência de Fibonacci (Obs: Pesquise na internet como a sequência
de Fibonacci é calculada).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 1, a = 0, b = 1;

            Console.Write("Digite a quantidade de termos (n): ");
            n = int.Parse(Console.ReadLine());

            while (cont <= n)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;

                cont++;
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}