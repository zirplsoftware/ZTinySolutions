using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Catalog
{
    public partial class TierPrice : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Catalog.DisplayProduct DisplayProduct { get; set; }
		public virtual int DisplayProductId { get; set; }
		public virtual int Quantity { get; set; }
		public virtual decimal PriceEach { get; set; }
    }
}

