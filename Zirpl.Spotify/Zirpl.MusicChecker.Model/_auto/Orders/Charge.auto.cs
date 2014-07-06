using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public abstract partial class Charge : AuditableBase<int>
    {
		public virtual DateTime Date { get; set; }
		public virtual decimal Amount { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.ChargeType ChargeType { get; set; }
		public virtual byte ChargeTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.ChargeMethodType ChargeMethodType { get; set; }
		public virtual byte ChargeMethodTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.ChargeStatusType ChargeStatusType { get; set; }
		public virtual byte ChargeStatusTypeId { get; set; }
		public virtual Zirpl.MusicChecker.Model.Orders.Order Order { get; set; }
		public virtual int OrderId { get; set; }
    }
}

