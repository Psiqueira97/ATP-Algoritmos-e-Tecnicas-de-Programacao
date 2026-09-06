/*09. Faça um programa que calcule o valor final da série para 30 termos.
S = 480 – 475 + 470 – 465 + 460 ...
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termo = 30, valorTermo = 480, somaSerie=0;
            bool somar = true;

            while (termo > 0)
            {
                if (somar==true)
                {
                    somaSerie += valorTermo;
                }
                else
                {
                    somaSerie -= valorTermo;
                }

                valorTermo -= 5;
                somar = !somar; //isso aqui foi macacada, basicamente fico negando o valor booleano da variavel somar a cada laço, era isso ou fazer fazer outro if else só para trocar o valor.
                termo--;
            }

            Console.WriteLine("A soma da Serie é: " + somaSerie);

            Console.ReadLine();
        }
    }
}
