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
	public partial class AddItemForm : Form
	{
		public Item thisitem = new Item();
		public AddItemForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			thisitem.ItemName = textBox1.Text;
			thisitem.ItemNum = Int32.Parse(textBox2.Text);
			thisitem.Perprice = Double.Parse(textBox3.Text);
			this.Close();
		}
	}
}
