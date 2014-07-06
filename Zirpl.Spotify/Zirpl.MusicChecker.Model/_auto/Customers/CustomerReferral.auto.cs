using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Customers
{
    public partial class CustomerReferral : Zirpl.MusicChecker.Model.Promotions.Referral
    {
		public virtual Zirpl.MusicChecker.Model.Customers.Customer ReferringCustomer { get; set; }
		public virtual int ReferringCustomerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.Discount ReferringCustomerDiscountAward { get; set; }
		public virtual int? ReferringCustomerDiscountAwardId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.DiscountUsage ReferringCustomerDiscountAwardUsage { get; set; }
		public virtual int? ReferringCustomerDiscountAwardUsageId { get; set; }
    }
}

