/*12. O dono de uma pequena loja de roupas permite que o cliente pague por seu produto em parcelas
mensais a uma determinada taxa de juros compostos. Com o intuito de apresentar imediatamente
ao cliente seu gasto total, o dono busca uma ferramenta que automatize o cálculo desse gasto. Para
ajudá-lo, crie um programa em C# que receba os seguintes dados sobre uma determinada compra:
capital inicial, taxa de juros e tempo de pagamento (em meses). E, então, imprima o valor do
montante dessa compra.
(Nota: Considere a fórmula juros compostos M = C(1+i)^t
, sendo M, C, i e t, o montante, o capital
inicial, a taxa de juros e o período de tempo respectivamente.)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double M, C, i;
            int t;

            Console.Write("Digite o valor da venda vista: ");
            C = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            i = double.Parse(Console.ReadLine());
            i = i / 100.00;//para incluir a porcentagem na fórmula tem que converter a porcentagem em decimal

            Console.Write("Digite o número de parcelas: ");
            t = int.Parse(Console.ReadLine());

            M = C * Math.Pow(1 + i, t);
            Console.WriteLine("\nO valor da compra a prazo é: R$ " + M.ToString("F2"));

            Console.ReadLine();
        }
    }
}
