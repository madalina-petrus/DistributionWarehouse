using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class PackageRepo
    {
        public List<Package> others =new List<Package>();
        public List<Package> fruits = new List<Package>();
        public List<Package> vegetables = new List<Package>();
        
        public void add(Package package)
        {
            if (package.Product.GetType() is Other)
                others.Add(package);
            else if (package.Product.GetType() is Fruit)
                fruits.Add(package);
            else if (package.Product.GetType() is Vegetable)
                vegetables.Add(package);
        }

        public void delete(Package package)
        {
            if (package.Product.GetType() is Other)
            //if (package.Category.Equals(Category.Others))
                others.Remove(package);
            //else if (package.Category.Equals(Category.Fruits))
            else if (package.Product.GetType() is Fruit)
                fruits.Remove(package);
            //else if (package.Category.Equals(Category.Fruits))
            else if (package.Product.GetType() is Vegetable)
                vegetables.Remove(package);
        }


    }
}
