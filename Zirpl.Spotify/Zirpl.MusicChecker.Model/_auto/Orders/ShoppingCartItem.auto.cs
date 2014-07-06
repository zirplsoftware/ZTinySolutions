using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class ShoppingCartItem : AuditableBase<int>
    {
		public virtual int Quantity { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.DisplayProduct DisplayProduct { get; set; }
		public virtual int DisplayProductId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Membership.Visitor Visitor { get; set; }
		public virtual int VisitorId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Catalog.SubscriptionChoice SubscriptionChoice { get; set; }
		public virtual int? SubscriptionChoiceId { get; set; }
		public virtual bool AddedWhileAnonymous { get; set; }
    }
}

