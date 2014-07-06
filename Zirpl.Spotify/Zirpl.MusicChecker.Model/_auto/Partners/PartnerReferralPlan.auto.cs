using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Partners
{
    public partial class PartnerReferralPlan : AuditableBase<int>
    {
		public virtual string Name { get; set; }
		public virtual decimal Amount { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.Discount ReferredCustomerAwardDiscount { get; set; }
		public virtual int ReferredCustomerAwardDiscountId { get; set; }
    }
}

