using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderLibrary;
using static OrderLibrary.ShoppingCart;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            Customer[] c = new Customer[2];
            Products[] p = new Products[2];
            Order[] o = new Order[2];
            for (int i = 0; i < 2; i++)
            {
                c[i] = new Customer();
                Console.WriteLine("Enter customer details:");
                Console.Write("Customer ID: ");
                c[i].CustomerId = int.Parse(Console.ReadLine());
                Console.Write("Customer Name: ");
                c[i].CustomerName = Console.ReadLine();
                p[i] = new Products();
                Console.WriteLine("Enter product details:");
                Console.Write("Product ID: ");
                p[i].ProductId = int.Parse(Console.ReadLine());
                Console.Write("Product Name: ");
                p[i].ProductName = Console.ReadLine();
                Console.Write("Quantity: ");
                p[i].Quantity = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                p[i].Price = int.Parse(Console.ReadLine());
                o[i] = new Order();
                Console.Write("Payment Mode: ");
                o[i].GetPaymentMode = (Order.PaymentMode) int.Parse(Console.ReadLine());
            }


            Console.WriteLine("******************************");

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Customer ID: " + c[i].CustomerId);
                Console.WriteLine("Customer Name: " + c[i].CustomerName);
                cart.AddToCart(p[i].ProductId, p[i].ProductName, p[i].Quantity, p[i].Price);
                cart.BuyNow();
                cart.PaymentGateway(p[i].Quantity * p[i].Price, o[i].GetPaymentMode);
                Console.WriteLine("-------------------------------");
            }

            Console.ReadLine();
        }
    }
}
