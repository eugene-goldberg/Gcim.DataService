using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemMemberPermissionsObject
    {
        public int ID { get; set; }
        public string Members { get; set; }
        public string Criteria { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowWrite { get; set; }
        public Nullable<bool> EffectiveRead { get; set; }
        public Nullable<bool> EffectiveWrite { get; set; }
        public Nullable<int> Owner_ID { get; set; }
        public virtual TypePermissionObject TypePermissionObject { get; set; }
    }
}
