/*02. Escreva um programa que leia dois números inteiros ímpares X e Y, e imprima os números ímpares de X até Y
(inclusive). Caso o usuário informe valores inválidos (X e Y não serem ímpares, OU X ser maior que Y) o programa
deverá imprimir uma mensagem de erro (Erro! Valores Inválidos).
Exemplo: x = 3, y = 11
Impressão: 3, 5, 7, 9, 11*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("PARA EXECUTAR O PROGRAMA DIGITE VALORES IMPARES PARA X E Y: ");


            Console.Write("Digite o valor X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor Y: ");
            y = int.Parse(Console.ReadLine());

            if (x % 2 == 0 || y % 2 == 0 || x > y)
            {
                Console.WriteLine("Erro! Valores Inválidos.");
            }
            else
            {
                while (x <= y)
                {
                    Console.Write(x + ", ");
                    x += 2;
                }
            }

            Console.ReadLine();
        }
    }
}
