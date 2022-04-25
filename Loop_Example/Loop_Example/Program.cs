using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Example
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			int k=int.Parse(Console.ReadLine());
			for(int i=k;i<=10;i++)
			{
				Console.WriteLine("The value of {0}", i);
			}
			int m = int.Parse(Console.ReadLine());
			while(m<=10)
			{
				Console.WriteLine("The value of {0}", m);
				m++;
			}
			int j = int.Parse(Console.ReadLine());
			do
			{
				Console.WriteLine("The value of {0}", j);
				j++;
			} while (j <= 10);


		}
	}
}
