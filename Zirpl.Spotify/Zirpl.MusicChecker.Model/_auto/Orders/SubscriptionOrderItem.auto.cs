using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class SubscriptionOrderItem : Zirpl.MusicChecker.Model.Orders.OrderItem
    {
		public virtual Zirpl.MusicChecker.Model.Orders.SubscriptionOrderItemType SubscriptionOrderItemType { get; set; }
		public virtual byte SubscriptionOrderItemTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionPeriod SubscriptionPeriod { get; set; }
		public virtual int? SubscriptionPeriodId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionInstance TriggeredBySubscriptionInstance { get; set; }
		public virtual int? TriggeredBySubscriptionInstanceId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionInstance ResultingSubscriptionInstance { get; set; }
    }
}

