using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model
{
    public partial class NameSuffixType : DictionaryEntityBase<byte, NameSuffixTypeEnum>
    {
		public override string Name { get; set; }
    }
}

