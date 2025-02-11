using System;
//Code Written By Matt
class URI
{

    static void Main(string[] args)
    {
        String Carlos = Console.ReadLine();
        int A, B, C, Maior;

        string[] valores = Carlos.Split(" ");
        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        C = int.Parse(valores[2]);

        Maior = (A + B + Math.Abs(A - B)) / 2;

        Maior = (Maior + C + Math.Abs(Maior - C)) /2;

        Console.WriteLine(Maior + " eh o maior");
    }

}