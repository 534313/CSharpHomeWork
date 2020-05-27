namespace 结合EF框架的订单窗口
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class OrderContext : DbContext
	{
		public OrderContext()
			: base("name=OrderContext")
		{
			Database.SetInitializer(
		new DropCreateDatabaseAlways<OrderContext>());
		}
		public DbSet<Item> items { set; get; }
		public DbSet<Order> orders { set; get; }
		public DbSet<Customer> customers { set; get; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
