using System;
using System.Globalization;
//Code Written By Matt
class URI
{

    static void Main(string[] args)
    {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();

        int cod, qtd;
        double total, preco;

        string[] valores1 = linha1.Split(' ');
        cod = int.Parse(valores1[0]);
        qtd = int.Parse(valores1[1]);
        preco = double.Parse(valores1[2], CultureInfo.InvariantCulture);

        total = qtd * preco;

        string[] valores2 = linha2.Split(' ');
        cod = int.Parse(valores2[0]);
        qtd = int.Parse(valores2[1]);
        preco = double.Parse(valores2[2], CultureInfo.InvariantCulture);

        total += qtd * preco;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"),CultureInfo.InvariantCulture);
    }

}