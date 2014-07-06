using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Partners
{
    public partial class PartnerReferral : Zirpl.MusicChecker.Model.Promotions.Referral
    {
		public virtual Zirpl.MusicChecker.Model.Partners.PartnerReferralCouponRequest Request { get; set; }
		public virtual int? RequestId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Partners.Partner Partner { get; set; }
		public virtual int PartnerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Partners.PartnerReferralPlan Plan { get; set; }
		public virtual int? PlanId { get; set; }
    }
}

