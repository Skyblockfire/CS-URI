using System;
using System.Globalization;
//Code Written By Matt
class URI
{
    static void Main(string[] args)
    {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();

        double x1, y1, x2, y2;

        string[] val = linha1.Split(' ');
        x1 = double.Parse(val[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(val[1], CultureInfo.InvariantCulture);

        string[] val2 = linha2.Split(' ');
        x2 = double.Parse(val2[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(val2[1], CultureInfo.InvariantCulture);

        Console.WriteLine((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))).ToString("F4"));
    }
}