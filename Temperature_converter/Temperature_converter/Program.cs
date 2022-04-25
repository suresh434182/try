using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Demo
{
    class MyApplication
    {
        static void Main(string[] args)
        {
            double C = 0;
            double F;
            Console.WriteLine("Sr. No\t"+" "+"Temperature(Celsius)\t"+" "+"Temperature(Fahrenheit)");
            for (int i = 1; i <= 11; i++)
            {
               
                F = (C * 9 / 5) + 32;
                Console.WriteLine(i+"\t\t"+C+"\t\t"+F);
                C = C + 10;
            }
            Console.ReadKey();
        }
    }
}