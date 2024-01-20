using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpractice
{
    public class GameHelper
    {
        public static void ShowItemInfo(Item item)
        {
            Console.WriteLine("Thong tin cua vat pham: ");
            Console.WriteLine($"Ten vat pham: {item.itemName}");
            Console.WriteLine($"Pham chat: {item.rarelity}");
            Console.WriteLine($"Gia tri: {item.price}");
            Console.WriteLine($"So luong: {item.quantity}");
        }

        public static void ShowAllItemInfo(Item[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Thong tin cua vat pham: ");
                if (items[i] != null)
                {
                    ShowItemInfo(items[i]);
                }
            }
        }
        public static int GetRandom(int min,int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
