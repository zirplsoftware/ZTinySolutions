using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Promotions
{
    public abstract partial class Referral : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Promotions.PromoCode PromoCode { get; set; }
		public virtual int PromoCodeId { get; set; }
		public virtual DateTime? ReferredCustomerJoinedDate { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.Customer ReferredCustomer { get; set; }
		public virtual int? ReferredCustomerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.Discount ReferredCustomerAwardDiscount { get; set; }
		public virtual int? ReferredCustomerAwardDiscountId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.DiscountUsage ReferredCustomerAwardDiscountUsage { get; set; }
		public virtual int? ReferredCustomerAwardDiscountUsageId { get; set; }
    }
}

