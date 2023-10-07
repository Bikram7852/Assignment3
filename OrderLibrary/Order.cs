using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderLibrary.ShoppingCart;

namespace OrderLibrary
{
    public class Order
    {
        public enum PaymentMode
        {
            cash,
            upi,
            debit,
            credit,
            netbanking
        }

        private static int OrderIdCounter = 1000;

        public int OrderId { get; private set; }
        public DateTime OrderDate { get; set; }
        public PaymentMode GetPaymentMode { get; set; }

        public Order()
        {
            OrderId = GenerateOrderId();
            OrderDate = DateTime.Now;
        }

        private int GenerateOrderId()
        {
            return OrderIdCounter++;
        }
    }
}
