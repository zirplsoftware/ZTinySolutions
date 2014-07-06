using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class SubscriptionStatusType : DictionaryEntityBase<byte, SubscriptionStatusTypeEnum>
    {
		public override string Name { get; set; }
    }
}

