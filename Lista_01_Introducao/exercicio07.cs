/*06. Escreva um programa que leia dois números reais e armazene-os nas variáveis varA e varB.
Em seguida, troque os valores das duas variáveis de forma que a variável varA passe a ter o valor
da variável varB e vice-versa. Ao final, imprima os valores finais das variáveis.
*/

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
            double varA, varB, varC;

            Console.Write("Digite o valor da varA: ");
            varA = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da varB: ");
            varB = double.Parse(Console.ReadLine());

            varC = varA;
            varA = varB;
            varB = varC;

            Console.WriteLine("\nO novo valor de varA é: " + varA.ToString("F2"));
            Console.WriteLine("O novo valor de varB é: " + varB.ToString("F2"));

            Console.ReadLine();
        }
    }
}
