using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型链表类添加ForEach方法
{
	public class Node<T>
	{
		public Node<T> Next { get; set; }
		public T Data { get; set; }
		public Node(T t)
		{
			Next = null;
			Data = t;
		}
	}

	public class GenericList<T>
	{
		private Node<T> head;
		private Node<T> tail;
		public GenericList()
		{
			tail = head = null;
		}
		public Node<T> Head
		{
			get => head;

		}
		public void Add(T t)
		{
			Node<T> n = new Node<T>(t);
			if (tail == null)
			{
				head = tail = n;
			}
			else
			{
				tail.Next = n;
				tail = n;
			}

		}
		public delegate void func(T x);
		public void ForEach(func func_)
		{
			for (Node<T> x = head; x != null; x = x.Next)
			{
				func_(x.Data);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Random rt = new Random();
			GenericList<int> Gen = new GenericList<int>();
			for (int i = 0; i < 10; i++)
			{
				Gen.Add(rt.Next(1, 20));
			}
			int sum = 0;
			int largest = 0;
			int smallest = 20;
			Gen.ForEach(m => sum += m);
			Gen.ForEach(m => Console.Write(m + ","));
			Console.WriteLine();
			Gen.ForEach(m => largest = (largest > m ? largest : m));
			Gen.ForEach(m => smallest = (smallest < m ? smallest : m));
			Console.WriteLine("元素之和为：" + sum);
			Console.WriteLine("元素中最大值为：" + largest);
			Console.WriteLine("元素中最小值为：" + smallest);
		}
	}
}
