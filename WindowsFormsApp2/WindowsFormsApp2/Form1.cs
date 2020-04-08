using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			tt();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label6.Text = "";
			label7.Text = "";
			label8.Text = "";
			label9.Text = "";
			label13.Text = "";
			label12.Text = "";
			Graphics g = this.panel1.CreateGraphics();
			g.Clear(this.panel1.BackColor);
			g.Dispose();
			if (graphics == null) graphics = this.panel1.CreateGraphics();
			int N;
			double Length;
			double lefttime;
			double righttime;
			double leftangle;
			double rightangle;
			if (!int.TryParse(this.textBox1.Text, out N))
			{
				label7.ForeColor = System.Drawing.Color.Red;
				label7.Text="递归次数应为整数";
			}
			if (!Double.TryParse(this.textBox2.Text, out Length))
			{
				label6.ForeColor = System.Drawing.Color.Red;
				label6.Text = "主干长度应为整数";
			}
			if (!Double.TryParse(this.textBox3.Text, out righttime))
			{
				label8.ForeColor = System.Drawing.Color.Red;
				label8.Text = "右分支倍数应为浮点数";
			}
			if (!Double.TryParse(this.textBox4.Text, out lefttime))
			{
				label9.ForeColor = System.Drawing.Color.Red;
				label9.Text = "左分支倍数应为浮点数";
			}
			if (!Double.TryParse(this.textBox5.Text, out rightangle))
			{
				label12.ForeColor = System.Drawing.Color.Red;
				label12.Text = "右分支角度应为浮点数";
			}
			if (!Double.TryParse(this.textBox6.Text, out leftangle))
			{
				label13.ForeColor = System.Drawing.Color.Red;
				label13.Text = "左分支角度应为浮点数";
			}
			drawCayleyTree(N, 200, 220, Length, -Math.PI / 2);
		}
		private Graphics graphics;

		void drawCayleyTree(int n, double x0, double y0, double leng, double th)
		{
			if (n == 0) return;
			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);
			drawLine(x0, y0, x1, y1);
			double th1 = Double.Parse(this.textBox5.Text) * Math.PI / 180;
			double th2 = Double.Parse(this.textBox6.Text) * Math.PI / 180;
			drawCayleyTree(n - 1, x1, y1, Double.Parse(this.textBox3.Text) * leng, th + th1);
			drawCayleyTree(n - 1, x1, y1, Double.Parse(this.textBox4.Text) * leng, th - th2);
		}
		void drawLine(double x0, double y0, double x1, double y1)
		{
			Brush b=System.Drawing.Brushes.Red;
			switch (comboBox1.SelectedItem.ToString())
			{
				case "红色":
					{
						b = System.Drawing.Brushes.Red;
						break;
					}
				case "绿色":
					{
						b = System.Drawing.Brushes.Green;
						break;
					}
				case "黑色":
					{
						b = System.Drawing.Brushes.Black;
						break;
					}
				case "黄色":
					{
						b = System.Drawing.Brushes.Yellow;
						break;
					}
				case "蓝色":
					{
						b = System.Drawing.Brushes.Blue;
						break;
					}
				default:
					{
						break;
					}
			}
			Pen a = new Pen(b,1);
			graphics.DrawLine(
				a,
				(int)x0, (int)y0, (int)x1, (int)y1);

		}
		public void tt()
		{
			comboBox1.Items.Add("红色");
			comboBox1.Items.Add("蓝色");
			comboBox1.Items.Add("绿色");
			comboBox1.Items.Add("黄色");
			comboBox1.Items.Add("黑色");
		}
		
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}
	}
}
