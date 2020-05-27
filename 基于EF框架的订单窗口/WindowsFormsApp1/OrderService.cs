using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace 结合EF框架的订单窗口
{
	class OrderService
	{
		public static List<Order> GetAllOrders()
		{
			using (var db = new OrderContext())
			{
				return db.orders.Include("Customer").Include("Items").ToList();
			}
		
		}
		public static Order GetOrderByName(String customerName)
		{
			return GetAllOrders().Where(a => a.CustomerName == customerName).First();
		}
		public static Order GetOrderByNumber(int OrderNum)
		{
			return GetAllOrders().Where(a => a.OrderNum == OrderNum).First();
		}
		public static void AddOrder(Order order)
		{
			using (var db = new OrderContext())
			{
				db.orders.Add(order);
				db.SaveChanges();
			}
		}
		public static void RemoveOrder(string id,string Customerid)
		{
			
				using (var db = new OrderContext())
				{
					var order = db.orders.Include("Items").Where(o => o.OrderId == id).FirstOrDefault();
					RemoveItems(id);
					db.orders.Remove(order);
					RemoveCustomer(Customerid);
			}
			
			
		}
		public static void RemoveItems(string orderId)
		{
			using (var db = new OrderContext())
			{
				var oldItems = db.items.Where(item => item.OrderId == orderId);
				db.items.RemoveRange(oldItems);
				db.SaveChanges();
			}
		}
		private static void RemoveCustomer(string id)
		{
			using (var db = new OrderContext())
			{
				var oldCustomer = db.customers.Where(customer => customer.CustomerId == id).FirstOrDefault();
				db.customers.Remove(oldCustomer);
				db.SaveChanges();
			}
		}
		public static void UpdateOrder(Order newOrder)
		{
			RemoveItems(newOrder.OrderId);
			using (var db = new OrderContext())
			{
				db.Entry(newOrder).State = EntityState.Modified;
				db.items.AddRange(newOrder.Items);
				db.SaveChanges();
			}
		}
	}
}
