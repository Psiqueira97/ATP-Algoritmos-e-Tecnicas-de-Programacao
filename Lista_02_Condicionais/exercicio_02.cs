/*02. Escreva um programa que leia 3 idades. Imprima a menor e a maior idade*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3;

            Console.WriteLine("DIGITE IDADES DISTINTAS:");


            Console.Write("Digite a 1ª idade: ");
            i1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 2ª idade: ");
            i2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a 3ª idade: ");
            i3 = int.Parse(Console.ReadLine());

            if (i1 < i2 && i1 < i3)
            {
                Console.WriteLine("A idade 1, " + i1 + " anos, é a menor idade");
            }
            else if (i2 < i1 && i2 < i3)
            {
                Console.WriteLine("A idade 2, " + i2 + " anos, é a menor idade");
            }
            else
            {
                Console.WriteLine("A idade 3, " + i3 + " anos, é a menor idade");
            }

            if (i1 > i2 && i1 > i3)
            {
                Console.WriteLine("A idade 1, " + i1 + " anos, é a maior idade");
            }
            else if (i2 > i1 && i2 > i3)
            {
                Console.WriteLine("A idade 2, " + i2 + " anos, é a maior idade");
            }
            else
            {
                Console.WriteLine("A idade 3, " + i3 + " anos, é a maior idade");
            }

            //O Programa quebra se houverem idades iguais

            Console.ReadLine();
        }
    }
}
