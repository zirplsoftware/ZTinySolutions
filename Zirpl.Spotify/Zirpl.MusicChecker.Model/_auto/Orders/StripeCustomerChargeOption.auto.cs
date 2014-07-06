using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Orders
{
    public partial class StripeCustomerChargeOption : Zirpl.MusicChecker.Model.Customers.CustomerChargeOption
    {
		public virtual string StripeCustomerId { get; set; }
		public virtual string Last4OfCreditCard { get; set; }
		public virtual string ExpirationMonthOfCreditCard { get; set; }
		public virtual string ExpirationYearOfCreditCard { get; set; }
		public virtual string CreditCardFingerPrint { get; set; }
		public virtual Zirpl.MusicChecker.Model.Address BillingAddress { get; set; }
		public virtual int BillingAddressId { get; set; }
    }
}

