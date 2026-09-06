/*03. Escreva um programa que leia do teclado 31 valores reais correspondentes ao índice pluviométrico diário da região
da Pampulha durante o mês de janeiro. O programa deve determinar e imprimir o índice pluviométrico médio, o índice
pluviométrico máximo e o dia que ele ocorreu. Obs: O índice pluviométrico refere-se à quantidade de chuva por metro
quadrado em determinado local.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max = 0, indice, total = 0, media;
            int dia = 1, diaMax = 1;

            while (dia <= 31)
            {
                Console.Write("Digite o índice pluviométrico do dia " + dia + "/1/2026: ");
                indice = double.Parse(Console.ReadLine());

                if (dia == 1 || indice > max)
                {
                    max = indice;
                    diaMax = dia;
                }

                total += indice;
                dia++;
            }

            media = total / 31.0;

            Console.WriteLine("\nO índice pluviométrico médio para o mês de janeiro foi: " + media.ToString("F2"));
            Console.WriteLine("O índice pluviométrico máximo foi: " + max.ToString("F2"));
            Console.WriteLine("Este registro máximo ocorreu no dia " + diaMax + "/1/2026");

            Console.ReadLine();
        }
    }
}