using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Promotions
{
    public partial class Discount : AuditableBase<int>
    {
		public Discount()
		{
			if (this.AppliesToDisplayProducts == null)
			{
				this.AppliesToDisplayProducts = new List<Zirpl.MusicChecker.Model.Catalog.DisplayProduct>();
			}
		}

		public virtual string Name { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.PromoCode PromoCode { get; set; }
		public virtual int PromoCodeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.DiscountApplicabilityType DiscountApplicabilityType { get; set; }
		public virtual byte DiscountApplicabilityTypeId { get; set; }
		public virtual decimal Amount { get; set; }
		public virtual Zirpl.MusicChecker.Model.Promotions.DiscountAmountType DiscountAmountType { get; set; }
		public virtual byte DiscountAmountTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.DiscountUsageRestrictionType DiscountUsageRestrictionType { get; set; }
		public virtual byte DiscountUsageRestrictionTypeId { get; set; }
		public virtual int? DiscountUsageRestrictionQuantity { get; set; }
		public virtual int? StopAfterChargeCyles { get; set; }
		public virtual DateTime? StartDate { get; set; }
		public virtual DateTime? EndDate { get; set; }
		public virtual bool Published { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Catalog.DisplayProduct> AppliesToDisplayProducts { get; set; }
    }
}

