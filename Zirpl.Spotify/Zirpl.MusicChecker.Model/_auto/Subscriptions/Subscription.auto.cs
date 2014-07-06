using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class Subscription : AuditableBase<int>
    {
		public virtual DateTime StartDate { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionStatusType StatusType { get; set; }
		public virtual byte StatusTypeId { get; set; }
		public virtual DateTime NextShipmentDate { get; set; }
		public virtual DateTime NextChargeDate { get; set; }
		public virtual bool AutoRenew { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.Customer Customer { get; set; }
		public virtual int CustomerId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Address ShippingAddress { get; set; }
		public virtual int ShippingAddressId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Customers.CustomerChargeOption CustomerChargeOption { get; set; }
		public virtual int CustomerChargeOptionId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Subscriptions.SubscriptionInstance CurrentSubscriptionInstance { get; set; }
		public virtual int? CurrentSubscriptionInstanceId { get; set; }
    }
}

