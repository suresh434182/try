using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_fial
{
    public class BookShelf : Furniture
    {
        public int NoOfShelves { get; set; }
        public override void Accept()
        {
            base.Accept();
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"{nameof(NoOfShelves)}  {NoOfShelves}");
        }
    }
}
