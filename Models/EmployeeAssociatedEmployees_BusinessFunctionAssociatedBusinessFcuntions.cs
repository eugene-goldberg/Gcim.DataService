using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions
    {
        public Nullable<System.Guid> AssociatedBusinessFcuntions { get; set; }
        public Nullable<System.Guid> AssociatedEmployees { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
