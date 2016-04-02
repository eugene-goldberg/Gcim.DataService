using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectArea
    {
        public SubjectArea()
        {
            this.SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions = new List<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions>();
            this.SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives = new List<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives>();
            this.SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities = new List<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities>();
            this.SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy = new List<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy>();
            this.SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents = new List<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents>();
            this.SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions = new List<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions>();
        }

        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions> SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public virtual ICollection<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives> SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives { get; set; }
        public virtual ICollection<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities> SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities { get; set; }
        public virtual ICollection<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy> SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy { get; set; }
        public virtual ICollection<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents> SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents { get; set; }
        public virtual ICollection<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions> SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions { get; set; }
    }
}
