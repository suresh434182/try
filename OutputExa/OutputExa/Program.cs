﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputExa
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var actions = new List();
			for (int i = 0; i < 4; i++) actions.Add(() => Console.WriteLine(i));
			
			Console.ReadKey();
        }
    }

	class List
	{
		public List()
		{
		}
	}
}
