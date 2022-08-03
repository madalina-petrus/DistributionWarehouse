using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class Package
    {
        public IProduct Product { get; set; }
        public DateOnly EntryDate { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public int Quantity { get; set; }

        public string toString()
        {
            return "Product: " + this.Product.toString()  +"\n Entry Date: " + this.EntryDate + ", Expiration Date: " +
                this.ExpirationDate + ", Quantity:" + this.Quantity;
        }

        public float pricePerPackage()
        {
            return Product.price(this.Quantity);
        }
    }
}
