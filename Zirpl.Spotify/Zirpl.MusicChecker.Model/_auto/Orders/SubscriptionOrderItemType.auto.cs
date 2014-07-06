using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class SubscriptionOrderItemType : DictionaryEntityBase<byte, SubscriptionOrderItemTypeEnum>
    {
		public override string Name { get; set; }
    }
}

