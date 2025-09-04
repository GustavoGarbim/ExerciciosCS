using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course7
{
    class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateOnly manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{Name} (Used) ${Price} (Manufacture date: {ManufactureDate})";
        }
    }
}
