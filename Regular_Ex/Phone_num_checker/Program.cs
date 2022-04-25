using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_num_checker
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter the Phone number");
			string phone_num = Console.ReadLine();
			
				if (Regex.Match(phone_num, @"^([0-9]{2}\-?[0-9]{3}\-?[0-9]{4})").Success)
					Console.WriteLine("valid");
				else
					Console.WriteLine("Invalid");
				Console.ReadKey();
			}
		}
		
	}
}
