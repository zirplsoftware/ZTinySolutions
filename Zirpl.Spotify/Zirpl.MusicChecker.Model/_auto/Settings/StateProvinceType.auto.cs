using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class StateProvinceType : DictionaryEntityBase<int, StateProvinceTypeEnum>
    {
		public override string Name { get; set; }
		public virtual string Abbreviation { get; set; }
    }
}

