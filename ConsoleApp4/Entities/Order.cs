using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using Console.Entities;
using Console.Entities.Enums;

namespace Console.Entities
{
    class Order
    {
        public DateTime momement { get; set; }
        public OrderStatus status { get; set; }
        public Client Client { get; set; }

        List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order(DateTime momement, OrderStatus status, Client client)
        {
            this.momement = momement;
            this.status = status;
            Client = client;
        }

        public void AddItem(OrderItem produto)
        {
            OrderItem.Add(produto);
        }

        public void RemoveItem(OrderItem produto) 
        {
            OrderItem.Remove(produto);
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

            sb.Append("Order moment: ");
            sb.AppendLine(momement.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach (OrderItem obj in OrderItem)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.Append("Total Price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
