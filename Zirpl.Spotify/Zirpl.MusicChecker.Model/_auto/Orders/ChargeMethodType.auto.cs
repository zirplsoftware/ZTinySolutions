﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class ChargeMethodType : DictionaryEntityBase<byte, ChargeMethodTypeEnum>
    {
		public override string Name { get; set; }
    }
}

