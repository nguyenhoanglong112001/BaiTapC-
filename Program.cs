using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPprac
{
    internal class Program
    {
        public static Item[] invetory = new Item[10];
        static void Main(string[] args)
        {
            do
            {
                int key = ShowGameUI();
                switch (key)
                {
                    case 1:
                        AddItem(invetory);
                        break;
                    case 3:
                        Console.WriteLine("danh sach vat pham: ");
                        ShowAllItem(invetory);
                        char Choice;
                        Console.WriteLine("Ban muon xoa mot so vat pham khong");
                        Choice = char.Parse(Console.ReadLine());
                        switch (Choice)
                        {
                            case 'Y':
                            case 'y':
                                {
                                    int idXoa = 0;
                                    Console.WriteLine("Nhap vat pham muon xoa: ");
                                    idXoa = int.Parse(Console.ReadLine());
                                    XoaItem(invetory, idXoa);
                                    break;
                                }
                            case 'n':
                            case 'N':
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Khong co lua chon nay");
                                    break;
                                }
                        }
                        break;
                    case 4:
                        thoat();
                        break;
                }
            } while (true);
            Console.ReadKey();
        }

        public static int ShowGameUI()
        {   Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("===========================");
            Console.WriteLine("1. Thêm vật phẩm");
            Console.WriteLine("2. Xóa vật phẩm");
            Console.WriteLine("3. Hiển thị toàn bộ vật phẩm");
            Console.WriteLine("4. Thoát kho đồ");

            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public static void AddItem(Item[] items)
        {
            Console.Clear();
            Console.WriteLine("Nhap ten cua vat pham");
            string itemName = Console.ReadLine();
            Item item = new Item(itemName);
            if (GameHelper.GetRandom(0, 101) <= 1)
            {
                item.quality = (ItemQuality)3;
            }
            else if (GameHelper.GetRandom(0, 101) <= 15)
            {
                item.quality = (ItemQuality)2;
            }
            else if (GameHelper.GetRandom(0, 101) <= 100)
            {
                item.quality = (ItemQuality)1;
            }
            else
            {
                item.quality = (ItemQuality)0;
            }
            item.price = GameHelper.GetRandom(50, 500);
            item.quantity = 1;
            AddItemToArray(items, item);
            GameHelper.ShowItemInfo(item);
        }

        public static void AddItemToArray(Item[] items, Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
            SortItem(items);
        }

        public static void ShowAllItem(Item[] items)
        {
            Console.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{items[i].itemName}");
                }
            }
        }

        public static void SortItem(Item[] items)
        {
            Item temp = new Item();
            temp = items[0];
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] != null && items[j] != null)
                    {
                        if (items[i].quality < items[j].quality)
                        {
                            temp = items[i];
                            items[i] = items[j];
                            items[j] = temp;
                        }
                    }
                }
            }
        }

        public static void thoat()
        {
            Environment.Exit(0);
        }

        public static void XoaItem(Item[] items, int IndexDelete)
        {
            for (int i = 0;i < items.Length;i++)
            {
                if (i == IndexDelete)
                {
                    items[i] = null;
                    break;
                } 
            }
        }

        public static bool Compare(Item item1, Item item2)
        {
            if (item1 != null || item2 != null)
            { 
                if (item1.itemName.Equals(item2.itemName))
                {
                    if (item1.quality == item2.quality)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
