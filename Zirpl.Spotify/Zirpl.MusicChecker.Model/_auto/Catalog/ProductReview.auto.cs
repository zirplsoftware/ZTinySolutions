using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Catalog
{
    public partial class ProductReview : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Catalog.DisplayProduct DisplayProduct { get; set; }
		public virtual int DisplayProductId { get; set; }
		public virtual string ReviewerName { get; set; }
		public virtual string ReviewerLocation { get; set; }
		public virtual DateTime Date { get; set; }
		public virtual string Text { get; set; }
		public virtual int Stars { get; set; }
    }
}

