
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 结合EF框架的订单窗口
{
	[Serializable]
	public class Item
	{
		
		public string OrderId { set; get; }
		[ForeignKey("OrderId")]
		public Order myOrder { set; get; }
		[Key]
		public string ItemName 
		{
			set;
			get;
		}
	
		public int ItemNum
		{
			set;
			get;
		}
		public double Perprice
		{
			set;
			get;
		}
		public double ItemTotalPirce
		{
			get { return Perprice * ItemNum; }
		}
		public override bool Equals(object obj)
		{
			if (!(obj is Item)) { throw new System.ArgumentException(); }
			Item rec = obj as Item;
			return (rec.ItemName == ItemName);
		}
		public override string ToString()
		{
			return ("商品名："+ItemName+"。"+Environment.NewLine+"商品数："+ItemNum + Environment.NewLine + "单价：" + Perprice);
		}
	}
}
