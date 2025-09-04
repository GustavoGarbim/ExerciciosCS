using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course7
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            double total = Price + CustomsFee;
            return total;
        }
        public override string priceTag()
        {
            return $"{Name} ${TotalPrice()} (Customs fee: ${CustomsFee})";

        }
    }
}
