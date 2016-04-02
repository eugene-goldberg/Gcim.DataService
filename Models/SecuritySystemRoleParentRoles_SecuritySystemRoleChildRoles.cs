using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles
    {
        public Nullable<System.Guid> ChildRoles { get; set; }
        public Nullable<System.Guid> ParentRoles { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual SecuritySystemRole SecuritySystemRole { get; set; }
        public virtual SecuritySystemRole SecuritySystemRole1 { get; set; }
    }
}
