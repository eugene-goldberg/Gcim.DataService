using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataEntityMap : EntityTypeConfiguration<DataEntity>
    {
        public DataEntityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataEntities");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.InformationProduct_ID).HasColumnName("InformationProduct_ID");

            // Relationships
            this.HasMany(t => t.DataSources)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("DataEntityDataSources");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("DataSource_ID");
                    });

            this.HasMany(t => t.MasterDatas)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("MasterDataDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("MasterData_ID");
                    });

            this.HasMany(t => t.OdsDataAttributes)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("OdsDataAttributeDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("OdsDataAttribute_ID");
                    });

            this.HasMany(t => t.SourceTools)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("SourceToolDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("SourceTool_ID");
                    });

            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });

            this.HasMany(t => t.UdmDataAttributes)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmDataAttributeDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("UdmDataAttribute_ID");
                    });

            this.HasMany(t => t.Udms)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("Udm_ID");
                    });

            this.HasMany(t => t.UdmDimensions)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmDimensionDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("UdmDimension_ID");
                    });

            this.HasMany(t => t.UdmFacts)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmFactDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("UdmFact_ID");
                    });

            this.HasMany(t => t.UdmMeasures)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmMeasureDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("UdmMeasure_ID");
                    });

            this.HasOptional(t => t.InformationProduct)
                .WithMany(t => t.DataEntities)
                .HasForeignKey(d => d.InformationProduct_ID);

        }
    }
}
