using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions
    {
        public Nullable<System.Guid> AssociatedBusinessFunctions { get; set; }
        public Nullable<System.Guid> AssociatedBusinessQuestions { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual BusinessQuestion BusinessQuestion { get; set; }
    }
}
