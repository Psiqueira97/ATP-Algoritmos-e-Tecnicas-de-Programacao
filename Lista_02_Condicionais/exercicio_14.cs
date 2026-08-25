/*14. Faça um programa que leia a altura e o sexo de uma pessoa (F ou M), calcule e mostre o seu peso ideal,
utilizando as seguintes fórmulas:
• Para homens: (72,7 * h) – 58
• Para mulheres: (62,1 * h) – 44,7
(h é a altura)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            double altura;

            Console.WriteLine("Para descobrir o peso ideal digite:");

            Console.Write("Sexo (F ou M): ");
            sexo = char.Parse(Console.ReadLine());
            sexo = char.ToUpper(sexo);

            Console.Write("Digite a altura (em cm): ");
            altura = double.Parse(Console.ReadLine());
            altura = altura / 100;

            double peso = sexo == 'F' ? (62.1 * altura) - 44.7 : sexo == 'M' ? (72.7 * altura) - 58 : 0;
            /*Aqui eu me passei, coloquei um ternário dentro do outro, porque com um ternário apenas qualquer outra letra digitada cairia bo segundo caso.
            Dessa forma, eu transformo o peso em ZERO caso o sexo não seja F nem M e assim cai no if que dá a mensagem de erro.*/

            if (peso == 0)
            {
                Console.WriteLine("Sexo inválido");
            }
            else
            {
                Console.WriteLine("\nO peso ideal para a pessoa é: " + peso.ToString("F2") + "kg");
            }

            Console.ReadLine();
        }
    }
}
