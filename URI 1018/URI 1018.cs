using System;
//Code Written By Matt
internal class Program
{
    private static void Main(string[] args)
    {
        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] qtd = { 0, 0, 0, 0, 0, 0, 1 };

        int i;

        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine(valor);

        for (i = 0; i < cedulas.Length; i++)
        {
            qtd[i] = valor / cedulas[i];

            valor %= cedulas[i];

            Console.WriteLine($"{qtd[i]} nota(s) de R$ {cedulas[i]},00");
        }
    }
}