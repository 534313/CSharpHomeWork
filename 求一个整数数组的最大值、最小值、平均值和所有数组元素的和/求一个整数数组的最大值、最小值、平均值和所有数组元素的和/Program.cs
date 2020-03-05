using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求一个整数数组的最大值_最小值_平均值和所有数组元素的和
{
	class Program
	{
		public static void GetNum(int[] array,out int MaxNum,out int MinNum,out int sum,out int average) 
		{
			int TestNum = array[0];
			for (int i = 0; i < array.Length; i++) 
			{
				if (TestNum < array[i])
				{
					TestNum = array[i];
				}
			}
			MaxNum = TestNum;
			TestNum = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (TestNum > array[i])
				{
					TestNum = array[i];
				}
			}
			MinNum = TestNum;
			sum = 0;
			for (int i = 0; i < array.Length; i++) 
			{
				sum += array[i];
			}
			average = sum / array.Length;
		}
		static void Main(string[] args)
		{
			int max, min, sum, average;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			GetNum(array, out max, out  min, out sum, out average);
			Console.WriteLine("最大值为："+max);
			Console.WriteLine("最小值为：" + min);
			Console.WriteLine("和为：" + sum);
			Console.WriteLine("平均值为：" + average);
		}
	}
}
