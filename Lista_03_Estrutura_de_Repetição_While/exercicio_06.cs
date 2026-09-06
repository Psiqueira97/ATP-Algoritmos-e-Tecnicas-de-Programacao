/*06. Escreva um programa que apresente o menu de opções a seguir e permita ao usuário escolher a opção desejada.
Leia os dados necessários para executar a operação e mostre o resultado. Esse processo deverá ser repetido até que o
usuário escolha a opção 4.
Menu de opções:
1. Novo salário
2. Férias
3. Décimo terceiro
4. Sair
Opção 1: ler o salário de um funcionário, calcular e mostrar o novo salário usando as regras a seguir:
Salários Percentagem de aumento
Até R$999,99 15%
De R$1000,00 a R$2000,00 (inclusive) 10%
Acima de R$2000,00 5%
Opção 2: ler o salário de um funcionário, calcular e mostrar o valor de suas férias. Sabe-se que as férias equivalem a seu
salário acrescido de um terço do salário.
Opção 3: ler o salário de um funcionário e o número de meses de trabalho na empresa (no máximo doze), calcular e
mostrar o valor do décimo terceiro salário. Sabe-se que o décimo terceiro equivale a seu salário multiplicado pelo
número de meses de trabalho dividido por 12. Caso o usuário informe um número de meses inválido, o programa deverá
informar que o valor é inválido e deverá solicitar um novo valor, até que um valor válido seja informado.
Opção 4: sair do programa
Obs: caso seja informada uma opção ou um salário inválido (isto é, menor que zero), o programa deve solicitar um novo
valor, até que seja informado um valor válido.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, meses;
            double salario, novoSalario, valorFerias, valor13;

            while (opcao != 4)
            {
                Console.WriteLine("\nMENU DE OPÇÕES:");
                Console.WriteLine("1. Novo salário");
                Console.WriteLine("2. Férias");
                Console.WriteLine("3. Décimo terceiro");
                Console.WriteLine("4. Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine("Opção inválida! Digite uma opção entre 1 e 4.\n");
                }
                else if (opcao != 4)
                {
                    // Leitura e validação do salário para as opções 1, 2 e 3
                    Console.Write("Digite o salário do funcionário: R$");
                    salario = double.Parse(Console.ReadLine());

                    while (salario < 0)
                    {
                        Console.WriteLine("Salário inválido! Digite um valor maior ou igual a zero.");
                        Console.Write("Digite novamente o salário: R$");
                        salario = double.Parse(Console.ReadLine());
                    }

                    if (opcao == 1)
                    {
                        if (salario <= 999.99)
                        {
                            novoSalario = salario * 1.15;
                        }
                        else if (salario <= 2000.00)
                        {
                            novoSalario = salario * 1.10;
                        }
                        else
                        {
                            novoSalario = salario * 1.05;
                        }
                        Console.WriteLine("O novo salário com aumento é: R$" + novoSalario.ToString("F2"));
                    }
                    else if (opcao == 2)
                    {
                        valorFerias = salario + (salario / 3.0);
                        Console.WriteLine("O valor das férias é: R$" + valorFerias.ToString("F2"));
                    }
                    else if (opcao == 3)
                    {
                        Console.Write("Digite a quantidade de meses trabalhados (1 a 12): ");
                        meses = int.Parse(Console.ReadLine());

                        while (meses < 1 || meses > 12)
                        {
                            Console.WriteLine("Valor inválido! O número de meses deve ser de 1 a 12.");
                            Console.Write("Digite novamente a quantidade de meses: ");
                            meses = int.Parse(Console.ReadLine());
                        }

                        valor13 = (salario * meses) / 12.0;
                        Console.WriteLine("O valor do décimo terceiro é: R$" + valor13.ToString("F2"));
                    }
                }
            }

            Console.WriteLine("\nPrograma encerrado.");
            Console.ReadLine();
        }
    }
}