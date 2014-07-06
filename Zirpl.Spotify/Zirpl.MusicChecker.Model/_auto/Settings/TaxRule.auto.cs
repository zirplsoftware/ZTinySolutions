using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class TaxRule : AuditableBase<int>
    {
		public virtual decimal Rate { get; set; }
		public virtual Zirpl.MusicChecker.Model.Settings.StateProvinceType StateProvinceType { get; set; }
		public virtual int StateProvinceTypeId { get; set; }
    }
}

