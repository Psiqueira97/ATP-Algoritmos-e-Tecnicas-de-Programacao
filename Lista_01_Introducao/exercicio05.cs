/*05. Escreva um programa que leia a quantidade de eleitores de um município, o número de votos
brancos, nulos e válidos. Calcule e imprima o percentual de votos brancos, nulos e válidos.
*/

using System;
class exercicio_05
{
    static void Main(string[] args)
    {
        int vBrancos, vNulos, vValidos, vTotais;
        double vBrancosPercent, vNulosPercent, vValidosPercent;

        Console.Write("Digite a quantidade de Votos Brancos: ");
        vBrancos = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de Votos Nulos: ");
        vNulos = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de Votos Validos: ");
        vValidos = int.Parse(Console.ReadLine());

        vTotais = vBrancos + vNulos + vValidos;
        vBrancosPercent = 100.00 * vBrancos / vTotais;
        vNulosPercent = 100.00 * vNulos / vTotais;
        vValidosPercent = 100.00 * vValidos / vTotais;

        Console.WriteLine("\nVotos Totais Registrados: " + vTotais);

        Console.WriteLine("\nA VOTAÇÃO POSSUI:");
        Console.WriteLine(vBrancosPercent.ToString("F2") + "% de Votos Brancos.");
        Console.WriteLine(vNulosPercent.ToString("F2") + "% de Votos Nulos.");
        Console.WriteLine(vValidosPercent.ToString("F2") + "% de Votos Validos.");


        Console.ReadLine();
    }
}