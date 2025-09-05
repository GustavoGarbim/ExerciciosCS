using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAPI
{
    internal class OrderItem
    {
        public int quantity;
        public int price;

        public subTotal(int quantity, int price)
        {
            double subtotal = quantity * price;
            return subtotal;
        }
    }
}
