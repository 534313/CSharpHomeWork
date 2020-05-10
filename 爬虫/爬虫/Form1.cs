using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
namespace 爬虫
{
	public partial class Form1 : Form
	{
		BindingSource bindingSource1 = new BindingSource();
		SimpleCrawler myCrawler = new SimpleCrawler();
		Thread thread = null;
		public Form1()
		{
			InitializeComponent();
			dataGridView1.DataSource = bindingSource1;
			
			textBox1.Text = "http://www.cnblogs.com/dstang2000/";
			myCrawler.PageDownloaded += Crawler_PageDownloaded;
			myCrawler.CrawlerStopped += Crawler_CrawlerStopped;
		}
		private void Crawler_CrawlerStopped(SimpleCrawler obj)
		{
			Action action = () => label2.Text = "爬虫已停止";
			if (this.InvokeRequired)
			{
				this.Invoke(action);
			}
			else
			{
				action();
			}
		}

		private void Crawler_PageDownloaded(SimpleCrawler crawler, string url, string info)
		{
			var pageInfo = new { Index =bindingSource1.Count + 1, URL = url, Status = info };
			Action action = () => { bindingSource1.Add(pageInfo); };
			if (this.InvokeRequired)
			{
				this.Invoke(action);
			}
			else
			{
				action();
			}
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bindingSource1.Clear();
			myCrawler.StartURL = textBox1.Text;

			Match match = Regex.Match(myCrawler.StartURL, SimpleCrawler.urlParseRegex);
			if (match.Length == 0) return;
			string host = match.Groups["host"].Value;
			myCrawler.HostFilter = "^" + host + "$";
			myCrawler.FileFilter = ".html?$";

			if (thread != null)
			{
				thread.Abort();
			}
			thread = new Thread(myCrawler.Start);
			thread.Start();


		}
		
	}
}
