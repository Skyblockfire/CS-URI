using System;
using System.Globalization;
//Code Written By Matt
class URI
{
    static void Main(string[] args)
    {
        string Linha = Console.ReadLine();
        double A, B, C, pi = 3.14159;

        string[] values = Linha.Split(' ');
        A = double.Parse(values[0], CultureInfo.InvariantCulture);
        B = double.Parse(values[1], CultureInfo.InvariantCulture);
        C = double.Parse(values[2], CultureInfo.InvariantCulture);

        //A ideia não é apresentar o código limpo, por isso os códigos estarão visando a RESOLUÇÃO do problema e não o design ou arquitetura do software.
        // VOCÊ, POSSÍVEL RECRUTADOR OU SER QUE CONTRATOU O FREELANCE, não me julgue pelo beecrowd, no futuro haverá um portifólio melhor no meu github então acompanhe :D

        Console.WriteLine("TRIANGULO: " + ((A*C)/2).ToString("F3"));
        Console.WriteLine("CIRCULO: " + (C * C * pi).ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + ((A + B) * C / 2).ToString("F3"));
        Console.WriteLine("QUADRADO: " + (B * B).ToString("F3"));
        Console.WriteLine("RETANGULO: " + (A * B).ToString("F3"));
    }
}