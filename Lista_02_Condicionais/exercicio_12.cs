/*12. Escreva um programa, usando o comando SWITCH, para mostrar o menu de opções de
conversão, a seguir leia a opção do usuário e os dados necessários para executar cada operação.
Calcule a operação selecionada pelo usuário e imprima na tela o resultado. Caso o usuário
selecione uma opção inválida, o programa deve imprimir “Opção Inválida” (Obs.: Pesquise na
internet como fazer as conversões).
Conversões:
1. Converter de centímetros para metros
2. Converter de metros para centímetros
3. Converter de milímetros para metros
4. Converter de metros para milímetros*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select;
            double mm, cm, m;

            Console.WriteLine("TABELA DE CONVERSÃO DE UNIDADE DE MEDIDAS:\n");
            Console.WriteLine("1. Converter de centímetros para metros\r\n2. Converter de metros para centímetros\r\n3. Converter de milímetros para metros\r\n4. Converter de metros para milímetros\n");
            Console.Write("Digite a opção desejada: ");
            select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case (1):
                    Console.Write("Digite a medida em centimetros: ");
                    cm = double.Parse(Console.ReadLine());
                    m = cm / 100;
                    Console.Write("A medida " + cm + "cm convertida em metros é: " + m);
                    break;
                case (2):
                    Console.WriteLine("Digite a medida em metros: ");
                    m = double.Parse(Console.ReadLine());
                    cm = m * 100;
                    Console.Write("A medida " + m + "m convertida em centimetros é: " + cm);
                    break;
                case (3):
                    Console.Write("Digite a medida em milimetros: ");
                    mm = double.Parse(Console.ReadLine());
                    m = mm / 1000;
                    Console.Write("A medida " + mm + "mm convertida em metros é: " + m);
                    break;
                case (4):
                    Console.Write("Digite a medida em metros: ");
                    m = double.Parse(Console.ReadLine());
                    mm = m * 1000;
                    Console.Write("A medida " + m + "m convertida em milimetros é: " + mm);
                    break;
                default:
                    Console.Write("Opção Inválida");
                    break;
            }

            Console.ReadLine();
        }
    }
}
