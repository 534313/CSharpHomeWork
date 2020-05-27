using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结合EF框架的订单窗口
{
	[Serializable]
	public class Order 
	{
		[Key]
		public string OrderId { get; set; }
		public int OrderNum { get; set; }
		public string  CustomerId { get; set; }
		public string CustomerName { get => (Customer != null) ? Customer.CustomerName : ""; }
		[ForeignKey("CustomerId")]
		[Required]
		public  Customer Customer { get; set; }
		public List<Item> Items { get; set; }
		public Order() { OrderId = Guid.NewGuid().ToString();Items = new List<Item>(); }
		
		
		public double TotalPrice
		{
			get 
			{
				double total = 0;
				foreach (Item item1 in Items) { total += item1.ItemTotalPirce; }
				return total;
			}
		}
		public  bool equals(Order obj)
		{
			if (this.OrderNum == obj.OrderNum || this.CustomerName == obj.CustomerName) { return true; }
			else return false;
		}


	}
}
