using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class StripeCharge : Zirpl.MusicChecker.Model.Orders.Charge
    {
		public virtual string StripeChargeId { get; set; }
		public virtual decimal StripeFee { get; set; }
    }
}

