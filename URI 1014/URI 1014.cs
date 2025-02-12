using System;
using System.Globalization;
//Code Written By Matt
class URI
{
    static void Main(string[] args)
    {
        int Km = int.Parse(Console.ReadLine());
        double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine((Km/litros).ToString("F3") + " km/l");
    }
}