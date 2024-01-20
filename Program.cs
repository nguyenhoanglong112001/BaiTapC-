using OOPpractice;
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
        public static Item[] invetory = new Item[10];
        static void Main(string[] args)
        {
            int key = ShowGameUI();
            //Item[] invetory = new Item[10];
            switch (key)
            {
                case 1:
                    AddItem(ref invetory);
                    break;
                case 3:
                    Console.WriteLine("danh sach vat pham: ");
                    for (int i=0;i<invetory.Length;i++)
                    {
                        if (invetory[i] != null)
                        {
                            GameHelper.ShowItemInfo(invetory[i]);
                        }
                    }
                    char Choice;
                    Console.WriteLine("Ban muon xoa mot so vat pham khong");
                    Choice = char.Parse(Console.ReadLine());
                    switch(Choice)
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
                default:
                    {
                        Console.WriteLine("Khong co lua chon nay");
                        break;
                    }
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

        public static void AddItem(ref Item[] items)
        {
            Console.WriteLine("Nhap ten cua vat pham");
            string itemName = Console.ReadLine();
            Item item = new Item(itemName);
            if (GameHelper.GetRandom(0, 101) <= 5)
            {
                item.rarelity = (quality)3;
            }
            else if (GameHelper.GetRandom(0, 101) <= 15)
            {
                item.rarelity = (quality)2;
            }
            else if (GameHelper.GetRandom(0, 101) <= 40)
            {
                item.rarelity = (quality)1;
            }
            else
            {
                item.rarelity = (quality)0;
            }
            item.price = GameHelper.GetRandom(50, 500);
            item.quantity = 1;

            AddItemToArray(ref items, item);
            GameHelper.ShowItemInfo(item);
        }

        public static void AddItemToArray(ref Item[] items, Item item)
        {
            for (int i = 0; i < items.Length; i++)
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
            for (int i = 0; i < items.Length; i++)
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

        public static void XoaItem(Item[] items, int Idxoa)
        {
            for (int i =0;i< items.Length;i++)
            {
                if (items[i] != null)
                {
                    if (items[i].id == Idxoa)
                    {
                        items[i] = null;
                        break;
                    }
                }
            }
        }
    }
}
