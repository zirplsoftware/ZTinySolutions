using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Customers
{
    public partial class Customer : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Membership.Visitor Visitor { get; set; }
		public virtual int VisitorId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.PromoCode PromoCode { get; set; }
		public virtual int PromoCodeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Address CurrentShippingAddress { get; set; }
		public virtual int? CurrentShippingAddressId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.CustomerChargeOption CurrentCustomerChargeOption { get; set; }
		public virtual int? CurrentCustomerChargeOptionId { get; set; }
    }
}

