using System;
using System.Globalization;
//Code Written by Matt
class URI
{

    static void Main(string[] args)
    {
        string Nome = Console.ReadLine();
        double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), Comissao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)*15/100;
        Console.WriteLine("TOTAL = R$ " + (Salario + Comissao).ToString("F2", CultureInfo.InvariantCulture));
    }

}