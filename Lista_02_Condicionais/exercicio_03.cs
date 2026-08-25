/*03. Escreva um programa que leia a idade de uma pessoa, o tipo de habilitação que ela possui e o tempo
que ela possui carteira de habilitação. Verifique e informe se a pessoa possui os requisitos necessários para
tirar uma carteira de habilitação do tipo D. Caso ela não possua os requisitos, indique em uma mensagem
o motivo pelo qual ela não possui permissão.
Requisitos carteira habilitação tipo D:
1. Ter 21 anos completos;
2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C*/

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
            char carteira;
            int idade, tCarteira;

            Console.WriteLine("VERIFIQUE A ELIGIBIDADE PARA CNH D\n");

            Console.Write("Digite a categoria da CNH atual: ");
            carteira = char.Parse(Console.ReadLine());
            carteira = char.ToUpper(carteira);

            Console.Write("Digite a sua idade atual: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantos anos você possui sua abilitação: ");
            tCarteira = int.Parse(Console.ReadLine());

            if(idade >= 21 && carteira == 'B' && tCarteira >= 2)
            {
                Console.WriteLine("\nVocê pode tirar a CNH D");
            }else if(idade >= 21 && carteira == 'C' && tCarteira >= 1)
            {
                Console.WriteLine("\nVocê pode tirar a CNH D");
            }
            else
            {
                Console.WriteLine("\nVocê não pode tirar a CNH D");
            } 

            Console.ReadLine();
        }
    }
}
