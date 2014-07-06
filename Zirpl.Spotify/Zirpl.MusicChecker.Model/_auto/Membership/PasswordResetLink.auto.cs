using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Membership
{
    public partial class PasswordResetLink : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.Membership.User User { get; set; }
		public virtual Guid UserId { get; set; }
		public virtual Guid Token { get; set; }
		public virtual DateTime Expires { get; set; }
    }
}

