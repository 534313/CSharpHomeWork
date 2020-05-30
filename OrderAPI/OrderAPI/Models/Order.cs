using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPT.Models
{
    public class Order
    {
        public string Id { get; set; }

        public string Cname { get; set; }

        public List<OrderItem> orderItemList { get; set; }    

        public double Totalprice { get; set; }      
    }
}
