using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_loop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[6];
			bool isNum;
			for(int i=0;i< arr.Length; i++)
			{
				Console.WriteLine("Enter the arr[{0}] value ",i);
				do
				{
					isNum = int.TryParse(Console.ReadLine() , out arr[i]);
				}while(isNum==false);
			}
			for(int i=0;i<=arr.Length;i++)
			{
				Console.WriteLine("arr[{0}]",arr[i]);
			}
			Console.ReadLine();
		}
	}
}
