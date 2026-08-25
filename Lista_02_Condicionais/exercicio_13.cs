/*13. Escreva um programa, usando o comando SWITCH, que leia uma letra e informe se a letra é uma vogal
ou consoante. Considere que o usuário sempre irá informar uma letra. (Dica: não será necessário informar
diretamente no código todas as 26 letras. Pense em uma forma mais inteligente de fazer esse
processamento). */

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
            char letra;

            Console.Write("Digite uma letra para saber se é vogal ou consoante: ");
            letra = char.Parse(Console.ReadLine());

            letra = char.ToUpper(letra);

            switch (letra)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("\nA letra " + letra + " é uma vogal");
                    break;
                default:
                    Console.WriteLine("\nA letra " + letra + " é uma consoante");
                    break;
            }

            Console.ReadLine();
        }
    }
}
