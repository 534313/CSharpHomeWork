using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结合EF框架的订单窗口
{
	class ItemService
	{
		public static void Additem(Item item, Order order)
		{ 
			
		}
		private static void RemoveItems(string orderId)
		{
			using (var db = new OrderContext())
			{
				var oldItems = db.items.Where(item => item.OrderId == orderId);
				db.items.RemoveRange(oldItems);
				db.SaveChanges();
			}
		}
	}
}
