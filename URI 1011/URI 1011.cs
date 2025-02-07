using System;
//Code Written By Matt
class URI
{
    static void Main(string[] args)
    {
        double pi = 3.14159;
        Int64 R = int.Parse(Console.ReadLine());

        Console.WriteLine("VOLUME = " + ((4/3.0) * pi * (R*R*R)).ToString("F3"));
    }
}