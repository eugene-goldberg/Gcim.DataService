using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Entity
    {
        public Entity()
        {
            this.DataDictionaryItems = new List<DataDictionaryItem>();
            this.EntityAssociatedEntities_DataTableAssociatedDataTables = new List<EntityAssociatedEntities_DataTableAssociatedDataTables>();
            this.EntityAttributeEntities_AttributeEntityAttributes = new List<EntityAttributeEntities_AttributeEntityAttributes>();
            this.EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources = new List<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources>();
            this.EntityOwnedEntities_EmployeeEntityOwners = new List<EntityOwnedEntities_EmployeeEntityOwners>();
            this.GambiToolUsedInGambiTools_EntityReliesOnEntities = new List<GambiToolUsedInGambiTools_EntityReliesOnEntities>();
            this.InformationComponentRelatedInformationComponents_EntityRelatedEntities = new List<InformationComponentRelatedInformationComponents_EntityRelatedEntities>();
            this.MasterDataAssociatedMasterData_EntityAssociatedEntities = new List<MasterDataAssociatedMasterData_EntityAssociatedEntities>();
            this.SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities = new List<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities>();
            this.SynonimEntitySynonims_EntitySynonimEntities = new List<SynonimEntitySynonims_EntitySynonimEntities>();
        }

        public System.Guid Oid { get; set; }
        public string EntityName { get; set; }
        public string Description { get; set; }
        public string SubjectArea { get; set; }
        public string CorrespondingLdeName { get; set; }
        public string Usage { get; set; }
        public string Coverage { get; set; }
        public string Comments { get; set; }
        public string RelationshipType { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataDictionaryItem> DataDictionaryItems { get; set; }
        public virtual ICollection<EntityAssociatedEntities_DataTableAssociatedDataTables> EntityAssociatedEntities_DataTableAssociatedDataTables { get; set; }
        public virtual ICollection<EntityAttributeEntities_AttributeEntityAttributes> EntityAttributeEntities_AttributeEntityAttributes { get; set; }
        public virtual ICollection<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources> EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources { get; set; }
        public virtual ICollection<EntityOwnedEntities_EmployeeEntityOwners> EntityOwnedEntities_EmployeeEntityOwners { get; set; }
        public virtual ICollection<GambiToolUsedInGambiTools_EntityReliesOnEntities> GambiToolUsedInGambiTools_EntityReliesOnEntities { get; set; }
        public virtual ICollection<InformationComponentRelatedInformationComponents_EntityRelatedEntities> InformationComponentRelatedInformationComponents_EntityRelatedEntities { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_EntityAssociatedEntities> MasterDataAssociatedMasterData_EntityAssociatedEntities { get; set; }
        public virtual ICollection<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities> SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities { get; set; }
        public virtual ICollection<SynonimEntitySynonims_EntitySynonimEntities> SynonimEntitySynonims_EntitySynonimEntities { get; set; }
    }
}
