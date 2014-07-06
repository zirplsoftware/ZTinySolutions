using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Promotions
{
    public partial class PromoCode : AuditableBase<int>
    {
		public virtual string Code { get; set; }
    }
}

