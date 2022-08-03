using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class Vegetable:Other,IProduct
    {
        public string NutritionalQuality { get; set; }
        public string Producer { get; set; }

        public string toString()
        {
            return base.toString() + ", Nutritional Quality: " + this.NutritionalQuality + ", Producer: " + this.Producer;
        }
    }
}
