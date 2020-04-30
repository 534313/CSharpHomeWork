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
	public partial class Form2 : Form
	{
		
		public Order order = new Order();
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			order.OrderNumber = Form1.cnt++;
			Customer customer = new Customer();
			customer.CustomerName = textBox1.Text;
			order.Customer=customer;
			Item item = new Item();
			item.ItemName = textBox2.Text;
			int itemnum = 0;
			if (int.TryParse(textBox3.Text, out itemnum)) { item.ItemNum = itemnum;label4.Text = ""; }
			else { label4.Text = "输入字符不合法。"; }
			double itemprice = 0;
			if (Double.TryParse(textBox4.Text, out itemprice)) { item.Perprice = itemprice; label6.Text = ""; }
			else { label6.Text = "输入字符不合法。"; }
			if (label4.Text != "输入字符不合法。" && label6.Text != "输入字符不合法。")
			{
				order.addItem(item);
				Form3 form3 = new Form3();
				form3.Show();
				this.Close();
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.ShowDialog();
			List<Item> thisItem=new List<Item>();
			foreach (Item item in form4.thisItems)
			{
				thisItem.Add(item);
			}
			foreach (Item item in thisItem)
			{
				order.addItem(item);
			}
		}
	}
}
