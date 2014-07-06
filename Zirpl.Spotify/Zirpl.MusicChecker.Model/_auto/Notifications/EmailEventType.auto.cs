using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Notifications
{
    public partial class EmailEventType : DictionaryEntityBase<byte, EmailEventTypeEnum>
    {
		public override string Name { get; set; }
    }
}

