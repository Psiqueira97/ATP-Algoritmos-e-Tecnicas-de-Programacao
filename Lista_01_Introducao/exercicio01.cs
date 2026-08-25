/*01. Leia uma velocidade em km/h (quilômetros por hora) e apresente convertida em m/s (metros
por segundo). A fórmula de conversão é M = K/3.6, sendo K a velocidade em km/h e M em m/s.*/

using System;
class exercicio_1
{
    static void Main(string[] args)
    {
        double kmh, ms;

        Console.Write("Digite a velocidade em km/h: ");

        kmh = double.Parse(Console.ReadLine());

        ms = kmh / 3.6;

        Console.Write("\nA velocidade em m/s é: " + ms);

        Console.ReadLine();
    }
}
