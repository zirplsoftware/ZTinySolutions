using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class SubscriptionPeriod : AuditableBase<int>
    {
		public virtual int ChargePeriod { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionPeriodType ChargePeriodType { get; set; }
		public virtual byte ChargePeriodTypeId { get; set; }
		public virtual int ShipmentPeriod { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionPeriodType ShipmentPeriodType { get; set; }
		public virtual byte ShipmentPeriodTypeId { get; set; }
    }
}

