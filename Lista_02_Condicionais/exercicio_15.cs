/*15. Faça um programa que leia um número correspondente a um determinado ano e em seguida informe se
este ano é ou não é bissexto. Um ano é bissexto se ele for divisível por 400 OU se ele for divisível por 4 e
não por 100.
Exemplos de anos bissextos: 2000, 2004, 2040*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ano;
            Console.Write("Digite o ano para saber se é bissexto: ");
            ano = double.Parse(Console.ReadLine());

            Console.WriteLine(ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0) ? "O ano " + ano + " é bissexto" : "O ano " + ano + " NÂO é bissexto" ) ;
            //ABSOLUTE PROGRAMMING: rodou de segunda

            Console.ReadLine();
        }
    }
}
