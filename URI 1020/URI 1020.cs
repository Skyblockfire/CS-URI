using System;
//Code Written By Matt
internal class Program
{
    private static void Main(string[] args)
    {
        int dias = int.Parse(Console.ReadLine()), anos, meses;

        anos = dias/365;
        dias %= 365;

        meses = dias/30;
        dias %= 30;

        Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
    }
}