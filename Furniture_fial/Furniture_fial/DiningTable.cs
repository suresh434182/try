using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_fial
{
    public class DiningTable : Furniture
    {
        public int NoOfLegs { get; set; }
        public override void Accept()
        {
            base.Accept();
            NoOfLegs = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"{nameof(NoOfLegs)}  {NoOfLegs}");
        }
    }
}
