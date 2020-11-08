using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class Input
{
    public void InputTst()
    {
        
        Console.WriteLine("Entre com seu nome completo:");
        String nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto:");
        float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
        string[] vetor = Console.ReadLine().Split(' ');
        String lastName = vetor[0];
        int idade = int.Parse(vetor[1]);
        float altura = float.Parse(vetor[2], CultureInfo.InvariantCulture);

        Console.WriteLine("------------------------------");
        Console.WriteLine("Saida esperada:");
        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine(lastName);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

    }
}

