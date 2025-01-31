using System;
using System.Globalization;
//Code Written By Matt
class URI
{

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("MEDIA = " + (((A*3.5)+(B*7.5))/11).ToString("0.00000", CultureInfo.InvariantCulture));

    }

}