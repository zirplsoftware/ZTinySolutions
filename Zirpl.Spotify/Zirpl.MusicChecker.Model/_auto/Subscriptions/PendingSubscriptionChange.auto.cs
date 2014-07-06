using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class PendingSubscriptionChange : AuditableBase<int>
    {
		public virtual int Quantity { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.SubscriptionChoice SubscriptionChoice { get; set; }
		public virtual int SubscriptionChoiceId { get; set; }
    }
}

