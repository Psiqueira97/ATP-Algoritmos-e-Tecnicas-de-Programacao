/*01. Escreva um programa que imprima uma contagem regressiva de 10 até 1 e depois exiba "Feliz Ano Novo!".*/

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
            int x = 10;

            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.WriteLine("Feliz Ano Novo");

            Console.ReadLine();
        }
    }
}
