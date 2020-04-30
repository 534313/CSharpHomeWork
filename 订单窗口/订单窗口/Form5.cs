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
	public partial class Form5 : Form
	{
		private Order thisorder ;
		public Form5(Order order,int Num,String Name)
		{
			InitializeComponent();
			thisorder = order;
			itemBindingSource.DataSource = order.Item;
			label3.Text = Num.ToString();
			label5.Text = Name;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			thisorder.CustomerName = textBox2.Text;
			thisorder.Customer.CustomerName = textBox2.Text;
			label5.Text = thisorder.CustomerName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Item item = itemBindingSource.Current as Item;
			Form6 form6 = new Form6(item);
			form6.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.ShowDialog();
			foreach (Item item in form4.thisItems)
			{
				thisorder.addItem(item);
			}
			itemBindingSource.ResetBindings(true);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Item item = itemBindingSource.Current as Item;
			thisorder.delectItem(item.ItemName);
			itemBindingSource.ResetBindings(true);
		}
	}
}
