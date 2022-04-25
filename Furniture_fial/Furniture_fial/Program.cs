using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_fial
{
	class Program
	{
        static void Main(string[] args)
        {
            Furniture[] furnitures = new Furniture[] { new BookShelf { Color ="Red", Height=2, NoOfShelves= 2, Price= 100, Qty= 2, Width = 2  }, new DiningTable {

             Color ="Yellow", Height=3, NoOfLegs= 3, Price= 100, Qty= 3, Width = 3} };
            Program p = new Program();
            Console.WriteLine($"{nameof(p.AddToStock)} {p.AddToStock(furnitures)}");
            Console.WriteLine($"{nameof(p.ShowStockDetails)} {p.ShowStockDetails(furnitures)}");
            Console.WriteLine($"{nameof(p.TotalStockValue)} {p.TotalStockValue(furnitures)}");
            Console.ReadLine();
        }
        public int AddToStock(Furniture[] furnitures)
        {
            return furnitures.Length;
        }
        public double TotalStockValue(Furniture[] furnitures)
        {
            double stockValue = default;
            foreach (var item in furnitures)
            {
                stockValue = stockValue + (item.Qty * item.Price);
            }
            return stockValue;
        }
        public int ShowStockDetails(Furniture[] furnitures)
        {
            foreach (var item in furnitures)
            {
                item.Display();
            }
            return furnitures.Length;
        }
    }
}
