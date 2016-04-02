using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions
    {
        public Nullable<System.Guid> AssociatedBusinessFunctions { get; set; }
        public Nullable<System.Guid> AssociatedBusinessGoals { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual BusinessGoal BusinessGoal { get; set; }
    }
}
