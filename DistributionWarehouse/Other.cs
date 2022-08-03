using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class Other: IProduct
    {
        public string Name { get; set; }
        public string Unit { get; set; }

        public float QuantityPerUnit { get; set; }
        public float Price { get; set; }

        public string toString()
        {
            return "Name: " + this.Name + ", Measurable unit: " + this.Unit + " (" + this.QuantityPerUnit + ")"
                + ", Price/Unit: " + this.Price;
        }

        public float price(int nr)
        {
            return nr * this.Price;
        }

    }
}
