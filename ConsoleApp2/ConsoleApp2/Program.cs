using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		delegate double Func(double x);
		static double Intergral(Func f, double a, double b)
		{
			return f(a) + a + b;
		}
		static void Main(string[] args)
		{
			Func f = Math.Sin;
			Console.WriteLine(Intergral(f, Math.PI, Math.PI / 2));
		}
	}
}
