using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionWarehouse
{
    internal class ProductRepo
    {
        public List<Other> others = new List<Other>();
        public List<Fruit> fruits = new List<Fruit>();
        public List<Vegetable> vegetables = new List<Vegetable>();

        public IProduct findByNameOthers(string name)
        {
            for(int i = 0; i < others.Count; i++)
                if(others[i].Name.Equals(name))
                    return others[i];
            return null;
        }

        public Fruit findByNameFruits(string name)
        {
            for (int i = 0; i < fruits.Count; i++)
                if (fruits[i].Name.Equals(name))
                    return fruits[i];
            return null;
        }

        public Vegetable findByNameVegetables(string name)
        {
            for (int i = 0; i < vegetables.Count; i++)
                if (vegetables[i].Name.Equals(name))
                    return vegetables[i];
            return null;
        }


    }
}
