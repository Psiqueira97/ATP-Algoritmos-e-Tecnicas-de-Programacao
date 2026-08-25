/*13. Dados os pontos (x0, y0) e (x1, y1), a interpolação linear é a linha entre os dois pontos. Assim,

para um valor x no intervalo [x0 x1], o valor y é dado por:

y = y0 + (y1 - y0) * (x - x0) / (x1 - x0)

Faça programa em C# que leia os limites inferiores e superiores de dois intervalos, um valor interno

ao segundo intervalo e calcule o valor interpolado 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x0, x1, y0, y1, x, y;
            Console.WriteLine("PARA ENCONTRA O 'y interpolado' DIGITE:");

            Console.Write("Digite x0: ");
            x0 = double.Parse(Console.ReadLine());

            Console.Write("Digite x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite y0: ");
            y0 = double.Parse(Console.ReadLine());

            Console.Write("Digite y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Digite x: ");
            x = double.Parse(Console.ReadLine());

            y = y0 + (y1 - y0) * (x - x0) / (x1 - x0);
            Console.WriteLine("\nO valor do 'y interpolado' é: y=" + y.ToString("F2"));

            Console.ReadLine();
        }
    }
}
