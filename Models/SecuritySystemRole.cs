using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemRole
    {
        public SecuritySystemRole()
        {
            this.SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles = new List<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles>();
            this.SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles1 = new List<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles>();
            this.SecuritySystemTypePermissionsObjects = new List<SecuritySystemTypePermissionsObject>();
            this.SecuritySystemUserUsers_SecuritySystemRoleRoles = new List<SecuritySystemUserUsers_SecuritySystemRoleRoles>();
        }

        public System.Guid Oid { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsAdministrative { get; set; }
        public Nullable<bool> CanEditModel { get; set; }
        public virtual XPObjectType XPObjectType { get; set; }
        public virtual ICollection<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles> SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles { get; set; }
        public virtual ICollection<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles> SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles1 { get; set; }
        public virtual ICollection<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObjects { get; set; }
        public virtual ICollection<SecuritySystemUserUsers_SecuritySystemRoleRoles> SecuritySystemUserUsers_SecuritySystemRoleRoles { get; set; }
    }
}
