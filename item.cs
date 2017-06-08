using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8marta
{
    public class Item
    {
        public double Cost { get; set; }
        public type Type { get; set; }

        public Item(type type, int cost)
        {
            this.Type = type;
            this.Cost = cost;
            
        }
    }

    public enum type
    {
        Flower1,
        Flower2, 
        Paper,
        Green
    }
}
