/*15. Um triângulo é um polígono de três lados, sendo que cada lado é menor que a soma dos outros
dois lados. Assim, para que um triângulo seja válido, é necessário que o comprimento de seus lados
a, b e c obedeçam à seguinte regra:
a < |b + c|, b < |a + c| e c < |a + b|.
Escreva um programa C# que leia os três lados de um triângulo e verifique se tais valores realmente
formam um triângulo. Caso negativo, imprima mensagem na tela sobre a conclusão do teste.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("PARA VERIFICAR SE É UM TRIÂNGULO DIGITE: ");

            Console.Write("O comprimento do lado A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("O comprimento do lado B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("O comprimento do lado C: ");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b) {
                Console.WriteLine("As medidas a="+a+", b="+b+", c="+c+" formam um triângulo;");
            }
            else
            {
                Console.WriteLine("As medidas a=" + a + ", b=" + b + ", c=" + c + " NÃO formam um triângulo;");
            }

            Console.ReadLine();
        }
    }
}
