namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypePermissionObject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypePermissionObject()
        {
            SecuritySystemMemberPermissionsObjects = new HashSet<SecuritySystemMemberPermissionsObject>();
            SecuritySystemObjectPermissionsObjects = new HashSet<SecuritySystemObjectPermissionsObject>();
        }

        public int ID { get; set; }

        public bool AllowRead { get; set; }

        public bool AllowWrite { get; set; }

        public bool AllowCreate { get; set; }

        public bool AllowDelete { get; set; }

        public bool AllowNavigate { get; set; }

        public string TargetTypeFullName { get; set; }

        public int? Role_ID { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects { get; set; }
    }
}
