using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class SystemSetting : AuditableBase<int>
    {
		public virtual string Name { get; set; }
		public virtual string Value { get; set; }
    }
}

