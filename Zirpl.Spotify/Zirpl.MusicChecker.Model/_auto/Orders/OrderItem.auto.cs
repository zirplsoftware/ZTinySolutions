using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class OrderItem : AuditableBase<int>
    {
		public OrderItem()
		{
			if (this.DiscountUsages == null)
			{
				this.DiscountUsages = new List<Zirpl.MusicChecker.Model.Orders.DiscountUsage>();
			}
		}

		public virtual int Quantity { get; set; }
		public virtual string ItemName { get; set; }
		public virtual decimal ItemAmountBeforeDiscount { get; set; }
		public virtual decimal OriginalItemAmount { get; set; }
		public virtual bool Cancelled { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.Order Order { get; set; }
		public virtual int OrderId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.DisplayProduct DisplayProduct { get; set; }
		public virtual int DisplayProductId { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Orders.DiscountUsage> DiscountUsages { get; set; }
    }
}

