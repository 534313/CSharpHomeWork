using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出素数因子
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			Console.WriteLine("Please enter the number you want to operate:");
			if (!Int32.TryParse(Console.ReadLine(), out num))
			{
				Console.WriteLine("The number you enter is illegal.");
			}
			else 
			{
				for (int i = 2; i <= num;) 
				{
					if (num % i == 0)
					{
						Console.Write(i + ",");
						num /= i;
					}
					else 
					{
						i++;
					}
				}
			}
		}
	}
}
