using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08
{
    [Serializable]
    public class Good
    {
        public int GoodId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public Good() { }

        public override bool Equals(object obj)
        {
            return obj is Good good && GoodId == good.GoodId;
        }


        public Good(int id, double price, string name)
        {
            GoodId = id;
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return $"Good ID:{GoodId}, Good Name:{Name}, Good Price{Price}";
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
