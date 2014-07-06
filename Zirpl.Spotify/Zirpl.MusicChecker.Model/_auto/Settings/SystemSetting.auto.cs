using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model
{
    public partial class Address : AuditableBase<int>
    {
		public virtual Zirpl.MusicChecker.Model.NamePrefixType Prefix { get; set; }
		public virtual byte? PrefixId { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string MiddleName { get; set; }
		public virtual string LastName { get; set; }
		public virtual Zirpl.MusicChecker.Model.NameSuffixType Suffix { get; set; }
		public virtual byte? SuffixId { get; set; }
		public virtual string Position { get; set; }
		public virtual string CompanyName { get; set; }
		public virtual string StreetLine1 { get; set; }
		public virtual string StreetLine2 { get; set; }
		public virtual string City { get; set; }
		public virtual string PostalCode { get; set; }
		public virtual string PhoneNumber { get; set; }
		public virtual Zirpl.MusicChecker.Model.Settings.StateProvinceType StateProvinceType { get; set; }
		public virtual int? StateProvinceTypeId { get; set; }
    }
}

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

using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class StateProvinceType : DictionaryEntityBase<int, StateProvinceTypeEnum>
    {
		public override string Name { get; set; }
		public virtual string Abbreviation { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class SystemSetting : AuditableBase<int>
    {
		public virtual string Name { get; set; }
		public virtual string Value { get; set; }
    }
}

