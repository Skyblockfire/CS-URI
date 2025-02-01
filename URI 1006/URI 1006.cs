using System;
using System.Globalization;
//Code Written By Matt
class URI
{

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("MEDIA = " + (((A*2)+(B*3)+(C*5))/10).ToString("0.0", CultureInfo.InvariantCulture));
    }
}