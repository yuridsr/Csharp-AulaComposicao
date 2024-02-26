using Console.Entities;
using Console.Entities.Enums;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter cliente data");
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Email: ");
            string email = System.Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(System.Console.ReadLine());

            Client c1 = new Client(name, email, BirthDate);
            Order Order1 = new Order(DateTime.Now, status, c1);


            System.Console.Write("How many items to this order? ");
            int QtditensOrder = int.Parse(System.Console.ReadLine());


            for (int i = 1; i <= QtditensOrder; i++)
            {
                System.Console.WriteLine("Enter #{0} item data:", i);
                System.Console.Write("Product name: ");
                string n = System.Console.ReadLine();
                System.Console.Write("Product price:");
                double p = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);

                Product P = new Product(n, p);

                System.Console.Write("Quantity: ");
                int q = int.Parse(System.Console.ReadLine());

                Order1.AddItem(new OrderItem(q, p, P));

            }

            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMARY:");
            System.Console.WriteLine(Order1);

        }
    }

}
