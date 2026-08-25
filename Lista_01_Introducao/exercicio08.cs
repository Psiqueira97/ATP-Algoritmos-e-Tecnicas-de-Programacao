/*08. Escreva um programa que leia o valor gasto com as despesas realizadas em um restaurante e
um percentual de gorjeta, definida pelo consumidor. Imprima o valor da gorjeta e o valor total a ser
pago (despesa mais gorjeta).*/

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
            double consumacao, percentGorjeta, vlrGorjeta, totalComanda;

            Console.Write("Digite o valor consumação: R$");
            consumacao = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual da gorjeta: ");
            percentGorjeta = double.Parse(Console.ReadLine());

            vlrGorjeta = percentGorjeta / 100.00 * consumacao;
            totalComanda = consumacao + vlrGorjeta;

            Console.WriteLine("\n=======================================");
            Console.WriteLine("        RESTAURANTE PÉ DE PORCO        ");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Valor do itens consumidos:.....R$" + consumacao.ToString("F2"));
            Console.WriteLine("Valor da gorjeta ("+percentGorjeta+"%):.........R$" + vlrGorjeta.ToString("F2"));
            Console.WriteLine("\nTOTAL:.........................R$" + totalComanda.ToString("F2"));
            Console.WriteLine("\n=======================================");




            Console.WriteLine();
        }
    }
}
