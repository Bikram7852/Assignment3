using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public class ShoppingCart : IOperations
    {
        
        private Customer customer;
        private Products product;
        public void AddToCart(int prodid, string productName, int qty, int price)
        {
            product = new Products
            {
                ProductId = prodid,
                ProductName = productName,
                Quantity = qty,
                Price = price
            };
        }

        public void BuyNow()
        {
            Order order = new Order();
            Console.WriteLine("Order placed successfully!");
            Console.WriteLine("Order Details: ");
            Console.WriteLine("Order ID: " + order.OrderId);
            Console.WriteLine("Order Date: " + order.OrderDate);
            Console.WriteLine("Product Id: " + product.ProductId);
            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Quantity: " + product.Quantity);
            Console.WriteLine("Total Price: " + (product.Quantity * product.Price));
        }

        public void PaymentGateway(int amt, Order.PaymentMode paymode)
        {
            Console.WriteLine("Payment completed for amount: " + amt + " through: " + paymode);
        }
    }
}
