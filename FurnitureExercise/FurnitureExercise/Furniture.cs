using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureExercise
{
    internal class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
        int Height;
        int Width;
        string Color;
        double Price;
        int Qty;

        public virtual void Accept()
        {
            //code to accept height,width ,color,price and qty

        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color

        }
    }

}
