using System;
using System.Collections.Generic;
using System.Text;
using Unity_Csharp___Completo.ExercicioComposicao.Entities.Enums;
using System.Globalization;

namespace Unity_Csharp___Completo.ExercicioComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItem)
            {
                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());

            sb.AppendLine(Client.ToString());
             foreach (OrderItem item in OrderItem)
            {
                sb.AppendLine(item.ToString());
            }            
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
