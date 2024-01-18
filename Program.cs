using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = ShowGameUI();
            Item[] invetory = new Item[10];
            switch(key)
            {
                case 1:
                    AddItem(invetory);
                    break;
                case 3:
                    Console.WriteLine("danh sach vat pham: ");
                    ShowAllItem(invetory);
                    break;
                case 4:
                    thoat();
                    break;
            }
            Console.ReadKey();
        }

        public static int ShowGameUI()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("1. Them vat pham");
            Console.WriteLine("2. Xoa vat pham");
            Console.WriteLine("3. Hien thi toan bo vat pham");
            Console.WriteLine("4. Thoat");

            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public static void AddItem(Item[] items)
        {
            Console.WriteLine("Nhap ten cua vat pham");
            string itemName = Console.ReadLine();
            Item item = new Item(itemName);
            if (GameHelper.GetRandom(0,101) <= 5)
            {
                item.quality = (ItemQuality)3;
            }
            else if (GameHelper.GetRandom(0, 101) <=15)
            {
                item.quality = (ItemQuality)2;
            }
            else if (GameHelper.GetRandom(0, 101) <= 40)
            {
                item.quality = (ItemQuality)1;
            }
            else
            {
                item.quality = (ItemQuality)0;
            }
            item.price = GameHelper.GetRandom(50,500);
            item.quantity = 1;

            AddItemToArray(items,item);
            GameHelper.ShowItemInfo(item);
        }

        public static void AddItemToArray(Item[] items, Item item)
        {
            for (int i =0;i< items.Length;i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
        }
        public static void ShowAllItem(Item[] items)
        {
            for (int i=0;i< items.Length;i++)
            {
                if (items[i] != null)
                {
                    GameHelper.ShowItemInfo(items[i]);
                }
            }
        }

        public static void thoat()
        {
            Environment.Exit(0);
        }
    }
}
