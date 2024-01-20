using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    public enum quality
    {
        Common,
        Rare,
        Epic,
        Legendary
    }
    public class Item
    {
        public string itemName;
        public int id;
        public quality rarelity;
        public int price;
        public int quantity;

        public Item()
        {

        }

        public Item(string itemName)
        {
            this.itemName = itemName;
            this.id = GetHashCode();
        }
    }
}
