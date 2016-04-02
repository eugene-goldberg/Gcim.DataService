using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class XPObjectType
    {
        public XPObjectType()
        {
            this.SecuritySystemRoles = new List<SecuritySystemRole>();
            this.SecuritySystemTypePermissionsObjects = new List<SecuritySystemTypePermissionsObject>();
            this.SecuritySystemUsers = new List<SecuritySystemUser>();
        }

        public int OID { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }
        public virtual ICollection<SecuritySystemRole> SecuritySystemRoles { get; set; }
        public virtual ICollection<SecuritySystemTypePermissionsObject> SecuritySystemTypePermissionsObjects { get; set; }
        public virtual ICollection<SecuritySystemUser> SecuritySystemUsers { get; set; }
    }
}
