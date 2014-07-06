using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Membership
{
    public partial class Visitor : AuditableBase<int>
    {
		public Visitor()
		{
			if (this.ShoppingCartItems == null)
			{
				this.ShoppingCartItems = new List<Zirpl.MusicChecker.Model.Orders.ShoppingCartItem>();
			}
		}

		public virtual Guid Token { get; set; }
		public virtual bool IsAnonymous { get; set; }
		public virtual bool IsAbandoned { get; set; }
		public virtual string BotUserAgent { get; set; }
		public virtual DateTime LastActivityDate { get; set; }
		public virtual IList<Zirpl.MusicChecker.Model.Orders.ShoppingCartItem> ShoppingCartItems { get; set; }
		public virtual Zirpl.MusicChecker.Model.Membership.User User { get; set; }
		public virtual Guid? UserId { get; set; }
    }
}

