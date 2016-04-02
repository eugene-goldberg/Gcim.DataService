using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals
    {
        public Nullable<System.Guid> RelatedSubjectGoals { get; set; }
        public Nullable<System.Guid> RelatedBusinessQuestions { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessGoal BusinessGoal { get; set; }
        public virtual BusinessQuestion BusinessQuestion { get; set; }
    }
}
