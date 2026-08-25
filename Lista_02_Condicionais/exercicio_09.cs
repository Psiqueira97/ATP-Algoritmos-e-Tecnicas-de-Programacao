/*09. Construa um código que leia o nome da empresa, nome de um funcionário, o cargo, o valor de salário
bruto e calcule o valor líquido após de dedução do INSS. A impressão deve ser nome, cargo, salário bruto,
desconto INSS e valor líquido. Nota: Há necessidade de consulta da tabela do INSS para obter alíquotas
corretas. Tal tabela é de livre acesso pela Internet.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empresa, cargo, nome;
            double salBruto, salLiquido;

            Console.WriteLine("========CALCULADORA  IMPOSTO DE RENDA========");

            Console.Write("\nDigite o nome da empresa: ");
            empresa = Console.ReadLine();

            Console.Write("Digite o nome do funcionário: ");
            nome = Console.ReadLine();

            Console.Write("Digite o cargo do funcionário: ");
            cargo = Console.ReadLine();

            Console.Write("Digite o salário do funcionário: R$");
            salBruto = double.Parse(Console.ReadLine());

            if (salBruto <= 2428.80)
            {
                salLiquido = salBruto;
            }
            else if (salBruto > 2428.80 && salBruto <= 2826.65)
            {
                salLiquido = salBruto * (1 - 0.075);
            }
            else if (salBruto > 2826.65 && salBruto <= 3751.05)
            {
                salLiquido = salBruto * (1 - 0.15);
            }
            else if (salBruto > 3751.05 && salBruto <= 4664.68)
            {
                salLiquido = salBruto * (1 - 0.225);
            }
            else
            {
                salLiquido = salBruto * (1 - 0.275);
            }

            Console.WriteLine("\n========RESULTADO DO IMPOSTO DE RENDA========\n");

            Console.WriteLine("Empresa: " + empresa);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salário Líquido: R$" + salLiquido.ToString("F2"));

            Console.ReadLine();
        }
    }
}
