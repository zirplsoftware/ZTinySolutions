using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Catalog
{
    public partial class SubscriptionChoiceTierPriceCombination : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Catalog.DisplayProduct DisplayProduct { get; set; }
		public virtual int DisplayProductId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.SubscriptionChoice SubscriptionChoice { get; set; }
		public virtual int? SubscriptionChoiceId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.TierPrice TierPrice { get; set; }
		public virtual int? TierPriceId { get; set; }
		public virtual decimal PriceEach { get; set; }
    }
}

