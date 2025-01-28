using System;
using System.Globalization;
//Code Written by Matt
class URI {

    static void Main(string[] args) { 
        double A, raio, pi = 3.14159;

        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        A = (raio * raio) * pi;
        
        A = Math.Round(A, 4);
        
        Console.WriteLine("A=" + A.ToString("0.0000", CultureInfo.InvariantCulture));
    }

}