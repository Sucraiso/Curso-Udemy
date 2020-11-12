using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioHierarquia.Entities;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioHierarquia
{
    class MainHiearquia
    {
        public void Exercicio()
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        list.Add(new UsedProduct(name, price, date));
                        break;

                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new ImportedProduct(name, price, customFee));
                        break;
                }
                                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
