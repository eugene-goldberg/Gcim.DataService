using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemTypePermissionsObject
    {
        public SecuritySystemTypePermissionsObject()
        {
            this.SecuritySystemMemberPermissionsObjects = new List<SecuritySystemMemberPermissionsObject>();
            this.SecuritySystemObjectPermissionsObjects = new List<SecuritySystemObjectPermissionsObject>();
        }

        public System.Guid Oid { get; set; }
        public string TargetType { get; set; }
        public Nullable<bool> AllowRead { get; set; }
        public Nullable<bool> AllowWrite { get; set; }
        public Nullable<bool> AllowCreate { get; set; }
        public Nullable<bool> AllowDelete { get; set; }
        public Nullable<bool> AllowNavigate { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public Nullable<int> ObjectType { get; set; }
        public Nullable<System.Guid> Owner { get; set; }
        public virtual ICollection<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }
        public virtual ICollection<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
        public virtual SecuritySystemRole SecuritySystemRole { get; set; }
        public virtual XPObjectType XPObjectType { get; set; }
    }
}
