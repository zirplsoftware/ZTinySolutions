using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Customers
{
    public abstract partial class CustomerChargeOption : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Customers.Customer Customer { get; set; }
		public virtual int CustomerId { get; set; }
    }
}

