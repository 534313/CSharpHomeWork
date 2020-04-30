using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 订单窗口
{

	public partial class Form1 : Form
	{
		private OrderService orderserive = new OrderService();
		public static int cnt = 1;
		public Form1()
		{
			InitializeComponent();

		}
		OrderService orderservice = new OrderService();

		private void orderServiceBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			Form2 form2 = new Form2();
			form2.ShowDialog();
			orderserive.TotalOrder.Add(form2.order);
			orderBindingSource.DataSource = orderserive.TotalOrder;
			orderBindingSource.ResetBindings(true);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Order order = orderserive.FindOrder(Int32.Parse(textBox1.Text));
			itemBindingSource.DataSource = order.Item;
			itemBindingSource.ResetBindings(true);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Order order = orderBindingSource.Current as Order;
			int Num = (orderBindingSource.Current as Order).OrderNumber;
			String Name = (orderBindingSource.Current as Order).CustomerName;
			Form5 form5 = new Form5(order,Num,Name);
			form5.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			orderserive.Export();
			System.Diagnostics.Process.Start("s.xml", "bin:\\Debug");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			orderserive.Import();
			orderBindingSource.DataSource = orderserive.TotalOrder;
		}
	}
}
