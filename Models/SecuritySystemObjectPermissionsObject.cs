using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SecuritySystemObjectPermissionsObject
    {
        public System.Guid Oid { get; set; }
        public string Criteria { get; set; }
        public Nullable<bool> AllowRead { get; set; }
        public Nullable<bool> AllowWrite { get; set; }
        public Nullable<bool> AllowDelete { get; set; }
        public Nullable<bool> AllowNavigate { get; set; }
        public Nullable<System.Guid> Owner { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual SecuritySystemTypePermissionsObject SecuritySystemTypePermissionsObject { get; set; }
    }
}
