using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemUser
    {
        public SecuritySystemUser()
        {
            this.SecuritySystemUserUsers_SecuritySystemRoleRoles = new List<SecuritySystemUserUsers_SecuritySystemRoleRoles>();
        }

        public System.Guid Oid { get; set; }
        public string StoredPassword { get; set; }
        public Nullable<bool> ChangePasswordOnFirstLogon { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public virtual XPObjectType XPObjectType { get; set; }
        public virtual ICollection<SecuritySystemUserUsers_SecuritySystemRoleRoles> SecuritySystemUserUsers_SecuritySystemRoleRoles { get; set; }
    }
}
