using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Partners
{
    public partial class Partner : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Membership.Visitor Visitor { get; set; }
		public virtual int VisitorId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Address Address { get; set; }
		public virtual int AddressId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Partners.PartnerReferralPlan ReferralPlan { get; set; }
		public virtual int? ReferralPlanId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.PromoCode PromoCode { get; set; }
		public virtual int PromoCodeId { get; set; }
		public virtual string CrmUrl { get; set; }
    }
}

