using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemUserUsers_SecuritySystemRoleRoles
    {
        public Nullable<System.Guid> Roles { get; set; }
        public Nullable<System.Guid> Users { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual SecuritySystemRole SecuritySystemRole { get; set; }
        public virtual SecuritySystemUser SecuritySystemUser { get; set; }
    }
}
