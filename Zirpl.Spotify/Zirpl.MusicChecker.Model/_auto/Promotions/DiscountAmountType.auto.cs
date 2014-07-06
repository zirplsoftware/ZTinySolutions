using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Promotions
{
    public partial class DiscountAmountType : DictionaryEntityBase<byte, DiscountAmountTypeEnum>
    {
		public override string Name { get; set; }
    }
}

