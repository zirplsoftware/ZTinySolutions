using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Catalog
{
    public partial class Brand : AuditableBase<int>
    {
		public virtual string Name { get; set; }
		public virtual string SeoId { get; set; }
		public virtual string Description { get; set; }
    }
}

