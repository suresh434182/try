using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductReposity productReposity = new ProductReposity();
            productReposity.FileRead();
            Console.ReadKey();
        }
    }
}
