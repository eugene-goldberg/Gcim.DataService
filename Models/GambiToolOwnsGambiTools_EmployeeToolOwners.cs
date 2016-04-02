using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GambiToolOwnsGambiTools_EmployeeToolOwners
    {
        public Nullable<System.Guid> ToolOwners { get; set; }
        public Nullable<System.Guid> OwnsGambiTools { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual GambiTool GambiTool { get; set; }
    }
}
