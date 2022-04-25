using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Design_Pattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for(int i=6;i>=1;i--)
			{
				for(int j=6;j>=1;j--)
				{
					if(i>=j)
						Console.Write("* ");
					else
						Console.Write(" ");
				}
				
				Console.WriteLine("");
			}
			Console.ReadLine();
		}
	}
}
