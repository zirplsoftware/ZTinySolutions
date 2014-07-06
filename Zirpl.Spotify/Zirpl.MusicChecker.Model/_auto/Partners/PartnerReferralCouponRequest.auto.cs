using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Partners
{
    public partial class PartnerReferralCouponRequest : AuditableBase<int>
    {
		public virtual DateTime RequestDate { get; set; }
		public virtual int Quantity { get; set; }
		public virtual DateTime? ShippedDate { get; set; }
		public virtual Zirpl.MusicChecker.Model.Partners.Partner Partner { get; set; }
		public virtual int PartnerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Partners.PartnerReferralCouponRequestStatusType PartnerReferralCouponRequestStatusType { get; set; }
		public virtual byte PartnerReferralCouponRequestStatusTypeId { get; set; }
    }
}

