﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订单窗口
{
	[Serializable]
	public class Customer
	{
		private string customerName;
		public string CustomerName
		{
			set { customerName = value; }
			get { return customerName; }
		}
	}
}
