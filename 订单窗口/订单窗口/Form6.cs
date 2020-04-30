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
	public partial class Form6 : Form
	{
		private Item thisitem = new Item();
		public Form6(Item item)
		{
			InitializeComponent();
			thisitem = item;
			label4.Text = item.ItemName;
			label5.Text = item.ItemNum.ToString();
			label6.Text = item.Perprice.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			thisitem.ItemNum = Int32.Parse(textBox1.Text);
			thisitem.Perprice = double.Parse(textBox2.Text);
			this.Close();
		}
	}
}
