using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consumo;
            double f1, f2, f3, f4, total;

            Console.Write("Digite o consumo de agua: ");
            consumo = int.Parse(Console.ReadLine());
            consumo /= 1000;

            if (consumo <= 75)
            {
                total = consumo * 3.67;
            }
            else
            {
                total = 75 * 3.67;
            }

            if (consumo > 75 && consumo <= 150)
            {
                total = total + (consumo-75) * 7.823;
            }
            else if (consumo > 150)
            {
                total = total + 75 * 7.823;
            }

            if (consumo > 150 && consumo <= 225)
            {
                total = total + (consumo - 150) * 12.124;
            }
            else if (consumo > 225)
            {
                total = total + 75 * 12.124;
            }

            if (consumo > 225)
            {
                total = total + (consumo - 225) * 16.551;
            }

            total = total + 305.55 + 226.05;
            Console.WriteLine("Fatura total: R$" + total.ToString("F2"));

            Console.ReadLine();
        }
    }
}
