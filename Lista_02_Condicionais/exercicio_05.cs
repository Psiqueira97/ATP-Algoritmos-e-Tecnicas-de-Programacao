/*05. Escreva um programa que leia quatro números inteiros positivos (w, x, y e z) e efetue o cálculo
de uma das seguintes médias de acordo com o valor de w conforme a tabela a seguir:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w, x, y, z, m;

            Console.WriteLine("ESCOLHA QUAL MÉDIA DESEJA CALCULAR:");
            Console.WriteLine("\n1 - Geométrica");
            Console.WriteLine("2 - Ponderada");
            Console.WriteLine("3 - Harmônica");
            Console.WriteLine("4 - Aritmética");
            Console.Write("\nOpção desejada: ");
            w = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o 1° valor: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2° valor: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3° valor: ");
            z = double.Parse(Console.ReadLine());

            if (w == 1)
            {
                m = Math.Sqrt(x * y * z);
                Console.WriteLine("\nA média Geométrica dos valores " + x + ", " + y + " e " + z + " é: " + m.ToString("F2"));
            }
            else if (w == 2)
            {
                m = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine("\nA média Ponderada dos valores " + x + ", " + y + " e " + z + " é: " + m.ToString("F2"));
            }
            else if (w == 3)
            {
                m = 1 / ((1 / x) + (1 / y) + (1 / z));
                Console.WriteLine("\nA média Harmônica dos valores " + x + ", " + y + " e " + z + " é: " + m.ToString("F2"));
            }
            else if (w == 4)
            {
                m = (x + y + z) / 3;
                Console.WriteLine("\nA média Aritmética dos valores " + x + ", " + y + " e " + z + " é: " + m.ToString("F2"));
            }
            else
            {
            Console.WriteLine("\nOPÇÃO DIGITADA INVÁLIDA");
            }

            Console.ReadLine();
        }
    }
}
