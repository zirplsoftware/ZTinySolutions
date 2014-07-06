using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class Order : AuditableBase<int>
    {
		public Order()
		{
			if (this.Charges == null)
			{
				this.Charges = new List<Zirpl.MusicChecker.Model.Orders.Charge>();
			}
			if (this.DiscountUsages == null)
			{
				this.DiscountUsages = new List<Zirpl.MusicChecker.Model.Orders.DiscountUsage>();
			}
			if (this.OrderItems == null)
			{
				this.OrderItems = new List<Zirpl.MusicChecker.Model.Orders.OrderItem>();
			}
		}

		public virtual DateTime Date { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.OrderChargeStatusType OrderChargeStatusType { get; set; }
		public virtual byte OrderChargeStatusTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.OrderStatusType OrderStatusType { get; set; }
		public virtual byte OrderStatusTypeId { get; set; }
		public virtual decimal SubtotalAmountBeforeDiscount { get; set; }
		public virtual decimal OriginalSubtotalAmount { get; set; }
		public virtual decimal OriginalTaxAmount { get; set; }
		public virtual decimal OriginalTotalAmount { get; set; }
		public virtual Zirpl.MusicChecker.Model.Address ShippingAddress { get; set; }
		public virtual int ShippingAddressId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.Customer Customer { get; set; }
		public virtual int CustomerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.CustomerChargeOption CustomerChargeOption { get; set; }
		public virtual int CustomerChargeOptionId { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Orders.Charge> Charges { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Orders.DiscountUsage> DiscountUsages { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Orders.OrderItem> OrderItems { get; set; }
    }
}

