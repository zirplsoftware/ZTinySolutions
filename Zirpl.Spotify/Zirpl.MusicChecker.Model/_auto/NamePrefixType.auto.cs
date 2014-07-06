using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model
{
    public partial class NamePrefixType : DictionaryEntityBase<byte, NamePrefixTypeEnum>
    {
		public override string Name { get; set; }
    }
}

