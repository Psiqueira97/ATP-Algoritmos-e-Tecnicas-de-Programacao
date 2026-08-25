
/*03. Escreva um programa que leia a base e a altura de um retângulo e imprima o seu perímetro,
área e diagonal.*/

using System;
class exercicio_1
{
    static void Main(string[] args)
    {
        double b, h, p, a, d;

        Console.Write("Digite o valor da base do retangulo: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retangulo: ");
        h = double.Parse(Console.ReadLine());

        p = b*2 + h*2;
        a = b * h;
        d = Math.Sqrt(b*b+h*h);

        Console.WriteLine("\nO perimetro do retangulo é: " + p);
        Console.WriteLine("A área do retangulo é: " + a);
        Console.WriteLine("A diagonal do retangulo é: " + d);

        Console.ReadLine();
    }
}
