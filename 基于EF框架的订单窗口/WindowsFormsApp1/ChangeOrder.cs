using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 结合EF框架的订单窗口
{
	public partial class ChangeOrder : Form
	{
		public Order thisOrder;
		public ChangeOrder(Order order)
		{
			thisOrder = order;
			InitializeComponent();
			orderBindingSource.DataSource = thisOrder;
			itemBindingSource.DataSource = thisOrder.Items;
			textBox1.Text = order.CustomerName;
		}
		private void UpdataData()
		{
			itemBindingSource.DataSource = thisOrder.Items;
			orderBindingSource.ResetBindings(true);
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddItemForm addItemForm = new AddItemForm();
			addItemForm.ShowDialog();
			using (var context = new OrderContext()) {
				var order = context.orders.Where(o => o.OrderId == thisOrder.OrderId).FirstOrDefault();
				order.Items.Add(addItemForm.thisitem);
				context.SaveChanges();
			}
				UpdataData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Item item = itemBindingSource.Current as Item;
			Item item1 = thisOrder.Items.Where(o => o.ItemName == item.ItemName).First();
			using (var context = new OrderContext())
			{
				var order = context.orders.Where(o => o.OrderId == thisOrder.OrderId).FirstOrDefault();
				Item item2 = order.Items.Where(o => o.ItemName == item1.ItemName).FirstOrDefault();
				order.Items.Remove(item2);
				context.SaveChanges();
			}
			UpdataData();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
