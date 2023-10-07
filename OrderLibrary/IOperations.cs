using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderLibrary.ShoppingCart;

namespace OrderLibrary
{
    public interface IOperations
    {
        void AddToCart(int prodid, string productName, int qty, int price);
        void PaymentGateway(int amt , Order.PaymentMode paymode);
        void BuyNow();
    }
}
