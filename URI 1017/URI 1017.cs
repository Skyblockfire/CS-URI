using System;
//Code Written by Matt
class URI
{

    static void Main(string[] args)
    {
        double tempo = double.Parse(Console.ReadLine()), kmhora = double.Parse(Console.ReadLine());

        Console.WriteLine((tempo * kmhora / 12).ToString("F3"));
    }

}