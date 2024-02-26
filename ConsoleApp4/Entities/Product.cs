using System;
using System.Globalization;
using System.Text;

namespace Console.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder S = new StringBuilder();

            S.Append(Name);
            S.Append(", $");
            S.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            return S.ToString();
        }

    }
}
