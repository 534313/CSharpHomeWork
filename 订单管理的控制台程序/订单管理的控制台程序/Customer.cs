using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订单管理的控制台程序
{
	class Customer
	{
		private string customerName;
		public string CustomerName
		{
			set { customerName = value; }
			get { return customerName; }
		}
	}
}
