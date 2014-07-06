using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Promotions
{
    public partial class DiscountApplicabilityType : DictionaryEntityBase<byte, DiscountApplicabilityTypeEnum>
    {
		public override string Name { get; set; }
    }
}

