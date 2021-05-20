﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08
{
    [Serializable]
    public class Good
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Good() { }

        public override bool Equals(object obj)
        {
            return obj is Good good &&
                   Price == good.Price &&
                   Name == good.Name;
        }


        public Good(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return "Good name:" + Name + ".   Good price:" + Price;
        }

        public override int GetHashCode()
        {
            int hashCode = -547978144;
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
