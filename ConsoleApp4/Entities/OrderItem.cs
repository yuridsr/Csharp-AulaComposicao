using System;
using System.Globalization;
using System.Text;

namespace Console.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder S = new StringBuilder();

            S.Append(Product);
            S.Append(", Quantity: ");
            S.Append(Quantity);
            S.Append(", Subtotal: $");
            S.Append(subTotal().ToString("F2", CultureInfo.InvariantCulture));
            return S.ToString();
        }

    }
}
