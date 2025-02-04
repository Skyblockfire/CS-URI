using System;
using System.Globalization;
//Code Written By Matt
class URI
{
    static void Main(string[] args)
    {
        int ID = int.Parse(Console.ReadLine()), QtdHoras = int.Parse(Console.ReadLine());
        double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        string saida = "NUMBER = " + ID + "\n" + "SALARY = U$ " + (QtdHoras*ValorHora).ToString("0.00", CultureInfo.InvariantCulture);
        
        Console.WriteLine(saida);
    }
}