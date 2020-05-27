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
    public class Customer
    {
        [Key]
        public string CustomerId { set; get; }
        public string CustomerName { get; set; }
        
        public Customer() { CustomerId = Guid.NewGuid().ToString(); }
        public Customer(string name):this() { CustomerName = name; }





    }
}
