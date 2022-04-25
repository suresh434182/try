using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2_Average_Temprature
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the total number of State");
			int K = int.Parse(Console.ReadLine());
			int[][] S = new int[K][];
			for(int i=0;i<K;i++)
			{
				Console.WriteLine("Enter the {0}th City in given state",i);
				int C = int.Parse(Console.ReadLine());
				S[i] = new int[C];
			}
			for (int i = 0; i < S.GetLength(0); i++)
			{
				for (int j = 0; j < S[i].Length; j++)
				{
					Console.WriteLine("Enter Temprature of the City arr[{0}][{1}]:-", i, j);
					S[i][j] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}
			Program obj = new Program();
			int res=obj.GetStateWiseAverage(K,S);
			Console.WriteLine(res);

			//for (int i = 0; i < S.GetLength(0); i++)
			//{
			//	for (int j = 0; j < S[i].Length; j++)
			//	{
			//		Console.WriteLine("arr[{0}][{1}]:-{2}", i, j, S[i][j]);
			//	}
			//	Console.WriteLine();
			//}
			Console.ReadLine();
		}
		public int GetStateWiseAverage(int k,int[][] arr)
		{
			int  sum = 0;
			int count = 0;
			for (int m = 0; m < k; m++)
			{
				for (int i = 0; i < arr.GetLength(0); i++)
					for (int j = 0; j < arr[i].Length; j++)
					{
						sum += arr[i][j];
						count++;
					}
				return sum / count;
			}
			return 0;
		}
	}
}

