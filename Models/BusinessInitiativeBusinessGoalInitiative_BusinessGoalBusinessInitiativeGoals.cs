using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals
    {
        public Nullable<System.Guid> BusinessInitiativeGoals { get; set; }
        public Nullable<System.Guid> BusinessGoalInitiative { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessGoal BusinessGoal { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
    }
}
