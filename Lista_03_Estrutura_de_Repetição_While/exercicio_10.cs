/*10. Escreva um programa que leia um número indefinido de notas de alunos e calcule a média. O programa deve parar
quando for digitado um valor negativo como nota.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota = 0, somaNota = 0, media = 0;
            int qtdAlunos = 1;

            Console.WriteLine("CALCULADORA DE MÉDIA DAS NOTAS\n(Para encerrar o lançamento das notas e obter a média digite uma nota negativa)\n\n");

            while (nota >= 0)
            {
                Console.Write("Digite a nota do " + qtdAlunos + "º aluno: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0)
                {
                    somaNota = somaNota + nota;
                    qtdAlunos++;
                }
            }

            media = somaNota / (qtdAlunos - 1);

            Console.WriteLine("\nA média da turma foi: " + media.ToString("F2") + " pontos na prova.");

            Console.ReadLine();
        }
    }
}
