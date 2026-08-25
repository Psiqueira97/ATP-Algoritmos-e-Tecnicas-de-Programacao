/*11. Escreva um programa, usando o comando SWITCH, que leia um número entre 0 e 4 e imprima o valor
lido por extenso (ex: “Quatro”), se o número estiver fora dessa faixa imprima “Valor inválido”.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número de 0 a 4: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case (0):
                    Console.WriteLine("Zero");
                    break;
                case (1):
                    Console.WriteLine("Um");
                    break;
                case (2):
                    Console.WriteLine("Dois");
                    break;
                case (3):
                    Console.WriteLine("Três");
                    break;
                case (4):
                    Console.WriteLine("Quatro");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
