using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Driven_Temprature_converter
{
	class Program
	{
		static void Main(string[] args)
		{
			int Option,F,C;
			Console.WriteLine("Enter your Choose");
			
			Console.WriteLine("1. Centigrade to Farenheit");
			Console.WriteLine("2. Farenheit to Centigrade");
			Option = int.Parse(Console.ReadLine());
			switch (Option)
				{
					case 1:
						Console.WriteLine("Enter the Centigrade");
						C = int.Parse(Console.ReadLine());
						F = (9 / 5 * C) + 32;
						Console.WriteLine("Value of Farenheit:- {0}", F);
						break;
					case 2:
						Console.WriteLine("Enter the farenheit");
						F = int.Parse(Console.ReadLine());
						C = (5 / 9 * F) - 32;
						Console.WriteLine("Value of Centigrade:- {0}", C);
						break;
					default:
						Console.WriteLine("Please Enter Valid Input");
						break;
				
			}
			Console.ReadLine();
		}
	}
}
