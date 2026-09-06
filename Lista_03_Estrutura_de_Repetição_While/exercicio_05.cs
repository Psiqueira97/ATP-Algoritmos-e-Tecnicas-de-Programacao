/*05. Faça um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escreva o quadrante a que ele pertence. O programa será encerrado quando as duas
coordenadas digitadas forem 0 (nesse caso, o programa deverá encerrar e nada deve ser escrito na tela).*/

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
            int x = 1, y = 1;

            while (x != 0 || y != 0)//usar OU para obter E
            {
                Console.Write("Digite a cordenada X: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Digite a cordenada Y: ");
                y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine(x + " " + y + ": Primeiro quadrante.\n");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine(x + " " + y + ": Segundo quadrante.\n");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine(x + " " + y + ": Terceiro quadrante.\n");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine(x + " " + y + ": Quarto quadrante.\n");
                }
                else if (x == 0 && y != 0) //O enunciado não prevê o que deve acontecer só uma das variáveis for ZERO então criei else if para eixo das ordenadas e abscisas
                {
                    Console.WriteLine("Ponto sobre o eixo das Ordenadas\n");
                }
                else if (x != 0 && y == 0)
                {
                    Console.WriteLine("Ponto sobre o eixo das Abscisas\n");
                }
                else
                {
                    Console.WriteLine("Ponto sobre a origem.");
                }
            }

            Console.WriteLine("\nFim do programa.");

            Console.ReadLine();
        }
    }
}
