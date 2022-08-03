using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class PackageService
    {
        public PackageRepo packageRepo;

        public float totalPrice(List<Package> packages)
        {
            float s=0;
            foreach (Package p in packages)
                s = s + p.pricePerPackage();
            return s;
        }
    }
}
