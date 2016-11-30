using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessEntityMap : EntityTypeConfiguration<BusinessEntity>
    {
        public BusinessEntityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessEntities");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.BusinessGoals)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("BusinessGoalBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("BusinessGoal_ID");
                    });

            this.HasMany(t => t.BusinessInitiatives)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("BusinessInitiativeBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("BusinessInitiative_ID");
                    });

            this.HasMany(t => t.BusinessQuestions)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("BusinessQuestionBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("BusinessQuestion_ID");
                    });

            this.HasMany(t => t.DataEntities)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("DataEntityBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("DataEntity_ID");
                    });

            this.HasMany(t => t.DataSources)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("DataSourceBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("DataSource_ID");
                    });

            this.HasMany(t => t.Governances)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("GovernanceBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("Governance_ID");
                    });

            this.HasMany(t => t.InformationProducts)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("InformationProductBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("InformationProduct_ID");
                    });

            this.HasMany(t => t.MasterDatas)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("MasterDataBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("MasterData_ID");
                    });

            this.HasMany(t => t.PerformanceMetrics)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("PerformanceMetricBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("PerformanceMetric_ID");
                    });

            this.HasMany(t => t.SourceTools)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("SourceToolBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("SourceTool_ID");
                    });

            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });

            this.HasMany(t => t.UdmDataAttributes)
                .WithMany(t => t.BusinessEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmDataAttributeBusinessEntities");
                        m.MapLeftKey("BusinessEntity_ID");
                        m.MapRightKey("UdmDataAttribute_ID");
                    });


        }
    }
}
