using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioComposicao.Entities;
using Unity_Csharp___Completo.ExercicioComposicao.Entities.Enums;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioComposicao
{
    public class MainExercicioComposicao
    {
        public void Exercicio()
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);
                    

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(status, client);
                                
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #"+i+" item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
