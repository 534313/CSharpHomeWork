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
	public partial class AddOrderForm : Form
	{
		public Order thisorder = new Order();
		private List<Item> thisitems = new List<Item>();
		public AddOrderForm()
		{
			InitializeComponent();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			Customer a = new Customer(name);
			thisorder = new Order() { Customer = a, Items = thisitems, OrderNum =OrderService.GetAllOrders().Count };

			OrderService.AddOrder(thisorder);
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddItemForm addItemForm = new AddItemForm();
			addItemForm.ShowDialog();
			thisitems.Add(addItemForm.thisitem);
			
			itemBindingSource.DataSource = thisitems;
			itemBindingSource.ResetBindings(true);
		}
	}
}
