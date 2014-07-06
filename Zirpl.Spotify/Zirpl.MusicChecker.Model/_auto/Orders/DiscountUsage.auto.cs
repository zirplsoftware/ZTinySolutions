using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class DiscountUsage : AuditableBase<int>
    {
		public virtual DateTime DateUsed { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.Discount Discount { get; set; }
		public virtual int DiscountId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.Order Order { get; set; }
		public virtual int OrderId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.OrderItem OrderItem { get; set; }
		public virtual int? OrderItemId { get; set; }
    }
}

