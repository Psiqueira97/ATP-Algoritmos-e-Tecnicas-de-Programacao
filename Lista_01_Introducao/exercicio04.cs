/*Escreva um programa que leia uma temperatura em graus Fahrenheit, calcule e mostre-a
convertida em graus Celsius.*/

using System;
class exercicio_1
{
    static void Main(string[] args)
    {
        double c, f;

        Console.Write("Digite a temperatura em Fahrenheit: ");

        f = double.Parse(Console.ReadLine());

        c = (5*(f-32))/(9);

        Console.Write("\nA temperatura em Celsius é: " + c);

        Console.ReadLine();
    }
}
