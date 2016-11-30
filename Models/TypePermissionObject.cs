using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class TypePermissionObject
    {
        public TypePermissionObject()
        {
            this.SecuritySystemMemberPermissionsObjects = new List<SecuritySystemMemberPermissionsObject>();
            this.SecuritySystemObjectPermissionsObjects = new List<SecuritySystemObjectPermissionsObject>();
        }

        public int ID { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowWrite { get; set; }
        public bool AllowCreate { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowNavigate { get; set; }
        public string TargetTypeFullName { get; set; }
        public Nullable<int> Role_ID { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }
        public virtual ICollection<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
    }
}
