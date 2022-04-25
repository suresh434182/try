using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_fial
{
    public class Furniture
    {
        //int Height;
        //int Width;
        //string Color;
        //double Price;
        //int Qty;
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public virtual void Accept()
        {
            Height = Convert.ToInt32(Console.ReadLine());
            Width = Convert.ToInt32(Console.ReadLine());
            Color = Console.ReadLine();
            Qty = Convert.ToInt32(Console.ReadLine());
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine($"{nameof(Height)}  {Height}");
            Console.WriteLine($"{nameof(Width)}  {Width}");
            Console.WriteLine($"{nameof(Color)}  {Color}");
            Console.WriteLine($"{nameof(Qty)}  {Qty}");
            Console.WriteLine($"{nameof(Price)}  {Price}");
        }
    }
}
