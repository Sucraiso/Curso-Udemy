using System;
using System.Globalization;

public class Formatacao
{
    public void Format()
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
        Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2}\n");

        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero:{2}\n", idade, codigo, genero);

        Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
        Console.WriteLine("Arrendondado (três casas decimais): {0}", medida.ToString("F3"));
        Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
    }

}
