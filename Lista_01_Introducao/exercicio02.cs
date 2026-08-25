
/*02. Escreva um programa que leia o lado de um quadrado e imprima o seu perímetro, área e
diagonal.*/

using System;
class exercicio_1
{
    static void Main(string[] args)
    {
        double l, p, a, d;

        Console.Write("Digite o valor do lado do quadrado: ");

        l = double.Parse(Console.ReadLine());

        p = l * 4;
        a = l * l;
        d = l * Math.Sqrt(2);

        Console.WriteLine("\nO perimetro do quadrado é: " + p);
        Console.WriteLine("A área do quadrado é: " + a);
        Console.WriteLine("A diagonal do quadrado é: " + d);

        Console.ReadLine();
    }
}
