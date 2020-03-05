using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用_埃氏筛法_求2__100以内的素数1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[99];
			for (int i = 2; i <= 100; i++)
			{
				array[i - 2] = i;
			}
			for (int i = 2; i < 10; i++) 
			{
				for (int t = 0; t < array.Length; t++)
				{
					if (array[t] % i == 0)
						array[t] = 0;
				}
			}
			Console.WriteLine("2-100以内的素数有：");
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					Console.Write(array[i] + ",");
				}
			}
		}
	}
}
