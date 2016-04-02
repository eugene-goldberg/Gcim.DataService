using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class InformationComponent
    {
        public InformationComponent()
        {
            this.InformationComponentRelatedInformationComponents_EntityRelatedEntities = new List<InformationComponentRelatedInformationComponents_EntityRelatedEntities>();
            this.SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents = new List<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents>();
        }

        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<InformationComponentRelatedInformationComponents_EntityRelatedEntities> InformationComponentRelatedInformationComponents_EntityRelatedEntities { get; set; }
        public virtual ICollection<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents> SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents { get; set; }
    }
}
