using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂

{
	public interface Shape_
	{
		bool Feasibility();
		int GetArea();
		void Draw();
	}
	public class Rectangle : Shape_
	{
		private int height, width;
		public Rectangle(int Height, int Width)
		{
			this.height = Height;
			this.width = Width;
		}
		public bool Feasibility()
		{
			if (this.height > 0 && this.width > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public int GetArea()
		{
			return height * width;
		}
		public void Draw()
		{
			Console.WriteLine("长方形");
		}
	}
	public class Square : Shape_
	{
		private int side;
		public Square(int Side)
		{
			this.side = Side;
		}
		new public int GetArea()
		{
			return side * side;
		}
		new public bool Feasibility()
		{
			if (side > 0)
				return true;
			else
				return false;
		}
		public void Draw()
		{
			Console.WriteLine("正方形");
		}
	}
	public class Triangle : Shape_
	{
		private int side1, side2, side3;
		public Triangle(int Side1, int Side2, int Side3)
		{
			this.side1 = Side1;
			this.side2 = Side2;
			this.side3 = Side3;
		}
		public int GetArea()
		{
			return (side1 + side2 + side3) * (side1 + side2 - side3) * (side1 - side2 + side3) * (side2 - side1 + side3) / 4;
		}
		public bool Feasibility()
		{
			return ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2));
		}
		public void Draw()
		{
			Console.WriteLine("三角形");
		}
	}
	class factory1
	{
		int size;
		public factory1(int i)
		{
			this.size = i;
		}
		public Shape_ Getshape()
		{
			Random r = new Random();
			switch (size)
			{

				case 0:
					{

						return new Rectangle(r.Next(1, 10), r.Next(1, 10));
					}
				case 1:
					{

						return new Square(r.Next(1, 10));
					}
				case 2:
					{

						Triangle shape0 = new Triangle(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10));
						while (!shape0.Feasibility())
						{
							shape0 = new Triangle(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10));
						}
						return shape0;
					}
				default:
					return null;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			float TotalArea = 0;
			for (int i = 0; i < 10; i++)
			{
				factory1 shape01 = new factory1(r.Next(0, 3));
				TotalArea += shape01.Getshape().GetArea();
				Console.Write("第" + (i + 1) + "个图形是");
				shape01.Getshape().Draw();
				Console.WriteLine("其面积是" + shape01.Getshape().GetArea());
			}
			Console.WriteLine("十个图形总面积是：" + TotalArea);
		}
	}
}
