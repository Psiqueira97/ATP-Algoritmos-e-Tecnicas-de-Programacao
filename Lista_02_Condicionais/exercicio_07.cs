/*07. Uma empresa de transporte urbano deseja automatizar o cálculo das informações do frete de cada
pedido, de forma a estimar qual são as opções possíveis para cada usuário, dado as seguintes regras:
• Existem 3 tipos de transporte: Caminhão, Van, Moto.
• Moto possui distância de entrega DIST de até 5km e peso máximo de carga de 20kg.
• Van possui peso máximo de carga de 1000kg.
• Caso seja necessário, o cliente pode designar a entrega como "Urgente"(URG), o que aumenta em
30% o preço do frete com Moto, 70% com Van e 100% com Caminhão.
• O preço por km PKM é R$ 1, tendo acréscimo de seguro no valor de 20% mais para Motos.
• Fórmula básica de cálculo do preço: P = (PKM ∗ D IST) ∗ URG
Escreva um programa que receba os dados distancia, peso e urgente do usuário e imprima o preço do frete
nas opções Moto, Van, Caminhão. Caso alguma dessas opções sejam inválidas, imprima "invalido"*/

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
            double preco, dist, peso;
            char urg;

            Console.WriteLine("CALCULE O FRETE");

            Console.Write("\nDigite o peso da mercadoria: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a distância entre a coleta e destino: ");
            dist = double.Parse(Console.ReadLine());

            Console.Write("\nDeseja enviar a mercadoria com urgência (S = Sim / N = Não): ");
            urg = char.Parse(Console.ReadLine());
            urg = char.ToUpper(urg);

            Console.WriteLine("TABELA DE PREÇOS:");

            //MOTO
            Console.Write("\nFRETE MOTO: ");
            if (dist <= 5 && peso <= 20 && urg == 'N')
            {
                preco = (dist * 1.2);
                Console.WriteLine("\nFrete Sem Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }
            else if (dist <= 5 && peso <= 20 && urg == 'S')
            {
                preco = (dist * 1.2 * 1.3);
                Console.WriteLine("\nFrete Com Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Categoria indisponível");
            }

            //VAN
            Console.Write("\nFRETE VAN: ");
            if (peso <= 1000 && urg == 'N')
            {
                preco = dist;
                Console.WriteLine("\nFrete Sem Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }
            else if (peso <= 1000 && urg == 'S')
            {
                preco = (dist * 1.7);
                Console.WriteLine("\nFrete Com Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Categoria indisponível");
            }

            //CAMINHAO
            Console.Write("\nFRETE CAMINHAO: ");
            if (urg == 'N')
            {
                preco = dist;
                Console.WriteLine("\nFrete Sem Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }
            else if (urg == 'S')
            {
                preco = (dist * 2);
                Console.WriteLine("\nFrete Com Urgência ");
                Console.WriteLine("Valor do frete: R$" + preco.ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}
