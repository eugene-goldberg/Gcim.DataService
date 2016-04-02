using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions
    {
        public Nullable<System.Guid> RelatedBusinessQuestions { get; set; }
        public Nullable<System.Guid> RelatedSubjectAreas { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessQuestion BusinessQuestion { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
