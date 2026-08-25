/*11. Um aluno de física do ensino médio estava aprendendo sobre o cálculo de pressão de gases,
quando teve a ideia de facilitar sua vida através da programação. Para ajudá-lo, crie um programa
em C# que receba os seguintes dados sobre um determinado gás: volume, número de mols e
temperatura (em kelvin). E, então, imprima o valor da pressão desse gás.
(Nota: Considere que o cálculo de pressão P possa ser obtido pela correlação PV = NRT, sendo
V, N e T, o volume, o número de mols, e a temperatura respectivamente; e a constante R = 0.082.)*/

/* P = N*R*T/V */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, v, n, r, t;

            r = 0.082;

            Console.Write("Digite o número de mols: ");
            n = double.Parse(Console.ReadLine());

            Console.Write("Digite a temperatura (em kelvin): ");
            t = double.Parse(Console.ReadLine());

            Console.Write("Digite o volume (em litros): ");
            v = double.Parse(Console.ReadLine());

            p = n * r * t / v;
            Console.WriteLine("\nA pressão é: " + p.ToString("F2") + "atm");

            Console.ReadLine();
        }
    }
}
