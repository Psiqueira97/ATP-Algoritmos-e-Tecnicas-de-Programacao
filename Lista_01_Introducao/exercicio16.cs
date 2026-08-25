/*16. Uma determinada loja de salgados vende a unidade de coxinha por 2.00 reais. Porém, esse
preço cai para 1.50 em encomendas com mais de 20 unidades. Crie um programa em C que receba
a quantidade de coxinhas em uma encomenda e imprima o preço total da compra.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int un;
            double total;

            Console.Write("Digite a quantidade de coxinhas compradas: ");
            un = int.Parse(Console.ReadLine());

            if (un < 21)
            {
                total = un * 2.00;
            }
            else
            {
                total = un * 1.50;
            }

            Console.WriteLine("O total do Pedido é: R$" + total);

            Console.ReadLine();
        }
    }
}
