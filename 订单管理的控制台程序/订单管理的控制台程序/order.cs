using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订单管理的控制台程序
{
	class Order : List<Item>
	{
		private int orderNumber;
		private List<Item> item = new List<Item>();
		private Customer customer;
		public int OrderNumber
		{
			set { orderNumber = value; }
			get { return orderNumber; }
		}
		public Customer Customer
		{
			set { customer = value; }
			get { return customer; }
		}
		public List<Item> Item
		{
			set { item = value; }
			get { return item; }
		}
		public Item FindItem(String ItemName)
		{
			return Item.Where(s => s.ItemName == ItemName).First() as Item;
		}
		public void addItem(Item addedItem)
		{
			bool ItemInOrder=false;
			if (item != null)
			{
				foreach (Item Item in item)
				{
					if (Item.Equals(addedItem))
					{
						ItemInOrder = true;
						break;
					}
				}
			}
			if (ItemInOrder == false)
			{
				item.Add(addedItem);
			}
			else 
			{
				Console.WriteLine("该商品在该订单中已经存在，现将仅修改数量。");
				var a = from b in item
						where b.ItemName == addedItem.ItemName
						select b;
				Item SameItem = a.First() as Item;
				SameItem.ItemNum += addedItem.ItemNum;
			}
		}
		public void delectItem(string ItemName)
		{
			bool ItemInOrder = false;
			Item WantedItem=new Item();
			if (item != null)
			{
				foreach (Item Item in item)
				{
					if (Item.ItemName==ItemName)
					{
						ItemInOrder = true;
						WantedItem = Item;
						break;
					}
				}
			}
			if (ItemInOrder)
			{
				this.Item.Remove(WantedItem);
			}
			else 
			{
				Console.WriteLine("该订单中没有该商品。");
			}
		}
		public void ChangeCustomer(string NewName) 
		{
			this.Customer.CustomerName = NewName;
		}
	}
}
