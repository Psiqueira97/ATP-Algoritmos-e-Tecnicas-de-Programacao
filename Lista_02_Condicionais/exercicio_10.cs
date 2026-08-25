/*10. Usando o comando switch, escreva um programa que leia um número inteiro entre 1 e 7 e imprima o
dia da semana correspondente ao número. Considere a semana iniciando no domingo (1). Caso o usuário
digite um valor menor que 1 ou maior que 7, seu programa deve exibir a mensagem: “Dia inválido”*/

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
            int dia;

            Console.Write("Digite um número de 1 a 7: ");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case (1):
                    Console.WriteLine("Domingo");
                    break;
                case (2):
                    Console.WriteLine("Segunda-Feira");
                    break;
                case (3):
                    Console.WriteLine("Terça-Feira");
                    break;
                case (4):
                    Console.WriteLine("Quarta-Feira");
                    break;
                case (5):
                    Console.WriteLine("Quinta-Feira");
                    break;
                case (6):
                    Console.WriteLine("Sexta-Feira");
                    break;
                case (7):
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Dia Inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
