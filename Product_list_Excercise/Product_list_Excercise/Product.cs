using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_list_Excercise
{
	class Product
	{
		private int pid;
		private string name;
		private double price;
		private int stock;
		public Product(int pid, string name,double price ,int stock )
		{
			this.pid = pid;
			this.name = name;
			this.price = price;
			this.stock = stock;
		}
		public string Name { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }

		
		public bool equals(object obj)
		{
			if(this==obj)
			{
				return true;
			}
			if (obj==null)
			{
				return false;
			}
			
			return true;
		}

		
	}
}
