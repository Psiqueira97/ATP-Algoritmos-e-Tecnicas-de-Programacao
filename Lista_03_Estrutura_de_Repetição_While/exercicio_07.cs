/*07. A prefeitura da cidade Melhor de Minas fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e
quantidade de anos de estudo. A prefeitura deseja saber:
1. média do salário da população;
2. média de anos de estudo;
3. maior salário;
4. percentual de pessoas com salário até R$5000,00.
5. percentual de pessoas com 15 ou mais anos de estudo.
Faça um programa para fazer esse processamento. A cada iteração, deve ser perguntado ao usuário se ele deseja informar
os dados de mais um habitante (S: sim, N: não).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaSalario = 0, mediaSalario, mediaEstudo, maiorSalario = 0, percentAte5K, percent15, salario;
            int qtdPessoas = 0, estudo, somaEstudo = 0, estudo15 = 0, ate5K = 0;
            char op = 'S';

            while (op == 'S')
            {
                Console.Write("Digite o tempo de escolaridade (anos): ");
                estudo = int.Parse(Console.ReadLine());

                Console.Write("Digite o salário: R$ ");
                salario = double.Parse(Console.ReadLine());

                somaSalario += salario;
                somaEstudo += estudo;

                if (qtdPessoas == 0 || salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario <= 5000)
                {
                    ate5K++;
                }

                if (estudo >= 15)
                {
                    estudo15++;
                }

                qtdPessoas++;

                Console.Write("\nDeseja continuar (S ou N)? ");
                op = char.Parse(Console.ReadLine());
                op = char.ToUpper(op);
                Console.WriteLine();
            }

            if (qtdPessoas > 0)
            {
                Console.WriteLine("RESULTADOS DA PESQUISA:");

                mediaSalario = somaSalario / qtdPessoas;
                Console.WriteLine("1. Média de salário: R$ " + mediaSalario.ToString("F2"));

                mediaEstudo = (double)somaEstudo / qtdPessoas;
                Console.WriteLine("2. Média de anos de estudo: " + mediaEstudo.ToString("F1") + " anos");

                Console.WriteLine("3. Maior salário: R$ " + maiorSalario.ToString("F2"));

                percentAte5K = (double)ate5K / qtdPessoas * 100;
                Console.WriteLine("4. Percentual com salário até R$ 5000,00: " + percentAte5K.ToString("F2") + "%");

                percent15 = (double)estudo15 / qtdPessoas * 100;
                Console.WriteLine("5. Percentual com 15 ou mais anos de estudo: " + percent15.ToString("F2") + "%");
            }

            Console.ReadLine();
        }
    }
}