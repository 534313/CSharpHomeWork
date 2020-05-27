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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			updateData();
			
		}
		private void updateData() 
		{
			List<Order> a = new List<Order>();
			a = OrderService.GetAllOrders();
			orderBindingSource.DataSource = a;
			orderBindingSource.ResetBindings(true);
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "按订单号")
			{
				int a = Int32.Parse(textBox1.Text);
				itemBindingSource.DataSource = OrderService.GetOrderByNumber(a).Items;
			}
			else 
			{
				String a = textBox1.Text;
				itemBindingSource.DataSource = OrderService.GetOrderByName(a).Items;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: 这行代码将数据加载到表“ordersDataSet.orders”中。您可以根据需要移动或删除它。
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddOrderForm addOrderForm = new AddOrderForm();
			addOrderForm.ShowDialog();
			updateData();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OrderService.RemoveOrder((orderBindingSource.Current as Order).OrderId, (orderBindingSource.Current as Order).CustomerId);
			updateData();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			ChangeOrder changeOrder = new ChangeOrder(orderBindingSource.Current as Order);
			changeOrder.ShowDialog();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
