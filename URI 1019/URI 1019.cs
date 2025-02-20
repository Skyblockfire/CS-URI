using System;
//Code Written By Matt
internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int Hora=0, Minuto=0, Segundo=0;

        Segundo = N;

        Hora = Segundo / 3600;
        Segundo %= 3600;

        Minuto = Segundo / 60;
        Segundo %= 60;
        
        Console.WriteLine($"{Hora}:{Minuto}:{Segundo}");
    }
}