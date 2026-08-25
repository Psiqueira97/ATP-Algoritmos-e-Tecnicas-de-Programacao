/*06. Escreva um programa que leia a idade de um nadador e classifique-o em uma das seguintes categorias:
 * Infantil A: 5-7 anos
 * Infantil B: 8-10 anos
 * Juvenil A: 11-13 anos
 * Juvenil B: 14-17 anos
 * Senior: > 18 anos */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite a idade do nadador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 5)
            {
                Console.WriteLine("Não é permitidade a matrícula de crianças abaixo de 5 anos.");
            } else if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("\nNadador classificado como: INFANTIL A");
            }
            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("\nNadador classificado como: INFANTIL B");
            }
            else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("\nNadador classificado como: JUVENIL A");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("\nNadador classificado como: INFANTIL A");
            }
            else
            {
                Console.WriteLine("\nNadador classificado como: SÊNIOR");
            }

            Console.ReadLine();
        }
    }
}
