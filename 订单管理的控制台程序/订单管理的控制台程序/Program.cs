using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订单管理的控制台程序
{
	class Program
	{
		public static int Ordernumber=0;
		static void Main(string[] args)
		{
			OrderService orderService = new OrderService();
		l1:
			{
				Console.WriteLine("以下为可执行操作");
				Console.WriteLine("0:查看订单。");
				Console.WriteLine("1:删除订单。");
				Console.WriteLine("2:添加订单。");
				Console.WriteLine("3:修改订单。");
				Console.Write("请选择你要做的操作：");
			}
			switch (Int32.Parse(Console.ReadLine()))
			{
				case 0:
					{
						Console.Clear();
						Console.Write("请输入你要查看的订单的订单号：");
						int Ordernum = Int32.Parse(Console.ReadLine());
						orderService.ViewOrder(Ordernum);
						break;
					}
				case 1:
					{
						Console.Clear();
						Console.Write("请输入你要删除的订单的订单号：");
						int Ordernum = Int32.Parse(Console.ReadLine());
						orderService.DelectOrder(Ordernum);
						break;
					}
				case 2:
					{
						Console.Clear();
						List<Item> allItem = new List<Item>();
						int Ordernum = ++Ordernumber;
						Console.Write("请输入顾客姓名:");
						Customer a = new Customer() { CustomerName = Console.ReadLine() };
					l2:
						{

							Console.Write("请输入商品名：");
							string Itemname = Console.ReadLine();
							Console.Write("请输入商品数目：");
							int Itemnum = Int32.Parse(Console.ReadLine());
							Console.Write("请输入商品单价：");
							Double Itemprice = Double.Parse(Console.ReadLine());

							Item NewItem = new Item()
							{
								ItemName = Itemname,
								ItemNum = Itemnum,
								Perprice = Itemprice
							};
							allItem.Add(NewItem);
						}
						Order t = new Order()
						{
							OrderNumber = Ordernum,
							Customer = a,
							Item = allItem
						};
						orderService.TotalOrder.Add(t);

						Console.WriteLine("该商品添加完成，该订单的订单号为：" + Ordernum);
					l3:
						{
							Console.WriteLine("是否在该订单中继续添加商品？");
							Console.WriteLine("0:是");
							Console.WriteLine("1:否");
							switch (int.Parse(Console.ReadLine()))
							{
								case 0:
									{
										goto l2;
									}
								case 1:
									{
										break;
									}
								default:
									{
										Console.WriteLine("输入无效指令，请继续输入：");
										goto l3;
									}
							}
							break;
						}

					}
				case 3:
					{
						Console.Clear();
						Console.Write("请选择你要进行修改的订单的订单号：");
						int OrderNumber = Int32.Parse(Console.ReadLine());
						Console.WriteLine("以下是你要修改的订单详情：");
						orderService.ViewOrder(OrderNumber);
						Console.WriteLine("-------------------------------");
						Console.WriteLine("以下是你可以进行的操作：");
						Console.WriteLine("0:修改客户名");
						Console.WriteLine("1:增添商品");
						Console.WriteLine("2:删除商品");
						Console.WriteLine("请选择你要做的修改操作：");
						switch (Int32.Parse(Console.ReadLine()))
						{
							case 0:
								{
									Console.Clear();
									Console.WriteLine("请输入新的用户名：");
									orderService.FindOrder(OrderNumber).ChangeCustomer(Console.ReadLine());
									break;
								}
							case 1:
								{
									List<Item> allItem = new List<Item>();
									Console.Write("请输入商品名：");
									string Itemname = Console.ReadLine();
									Console.Write("请输入商品数目：");
									int Itemnum = Int32.Parse(Console.ReadLine());
									Console.Write("请输入商品单价：");
									Double Itemprice = Double.Parse(Console.ReadLine());

									Item NewItem = new Item()
									{
										ItemName = Itemname,
										ItemNum = Itemnum,
										Perprice = Itemprice
									};
									orderService.FindOrder(OrderNumber).Item.Add(NewItem);
									break;

								}
							case 2:
								{
									Console.Write("请输入商品名：");
									string Itemname = Console.ReadLine();
									orderService.FindOrder(OrderNumber).delectItem(Itemname);
									break;
								}
						}
						break;
					}
				default:
					{
						Console.Clear();
						Console.WriteLine("输入了无效指令，请重新输入。");
						goto l1;
					}
			}
			Console.WriteLine("按任意键回到操作界面。");
			Console.ReadLine();
			goto l1;
		}
	}
}
