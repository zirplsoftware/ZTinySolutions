using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class SubscriptionInstance : AuditableBase<int>
    {
		public virtual DateTime StartDate { get; set; }
		public virtual int TotalShipments { get; set; }
		public virtual int ShipmentsRemaining { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.Subscription Subscription { get; set; }
		public virtual int SubscriptionId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.SubscriptionOrderItem CreatedByOrderItem { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.PendingSubscriptionChange PendingSubscriptionChange { get; set; }
		public virtual int? PendingSubscriptionChangeId { get; set; }
    }
}

