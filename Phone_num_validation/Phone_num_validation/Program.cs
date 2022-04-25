using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_num_validation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Regex regex = new Regex(@"^[1-9-]{1}[0-9-]{1}-[0-9-]{3}-[0-9-]{5}$");
				string str = Console.ReadLine();
				Console.WriteLine("{0} {1} a valid Mobile number ", str, regex.IsMatch(str) ? "is" : "is not");
				Console.ReadLine();
			}
		}
	}
}
