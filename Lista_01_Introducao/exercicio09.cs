/*09. Leia um ângulo em graus e apresente-o convertido em radianos. A fórmula de conversão é
R = G * π/180, sendo G o ângulo em graus e R em radianos e π = 3.141592.*/

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
            double graus, radianos;

            Console.Write("Digite o ângulo em graus: ");
            graus = double.Parse(Console.ReadLine());

            radianos = graus * 3.141592 / 180;

            Console.WriteLine("\n" + graus + " convertidos em radianos é: " + radianos.ToString("F2"));

            Console.ReadLine();
        }
    }
}
