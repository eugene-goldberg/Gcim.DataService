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
            this.Property(t => t.BiMeasure_ID).HasColumnName("BiMeasure_ID");
            this.Property(t => t.BiFact_ID).HasColumnName("BiFact_ID");
            this.Property(t => t.BiDimension_ID).HasColumnName("BiDimension_ID");

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

            this.HasMany(t => t.Udms)
                .WithMany(t => t.DataEntities)
                .Map(m =>
                    {
                        m.ToTable("UdmDataEntities");
                        m.MapLeftKey("DataEntity_ID");
                        m.MapRightKey("Udm_ID");
                    });

            this.HasOptional(t => t.BiDimension)
                .WithMany(t => t.DataEntities)
                .HasForeignKey(d => d.BiDimension_ID);
            this.HasOptional(t => t.BiFact)
                .WithMany(t => t.DataEntities)
                .HasForeignKey(d => d.BiFact_ID);
            this.HasOptional(t => t.BiMeasure)
                .WithMany(t => t.DataEntities)
                .HasForeignKey(d => d.BiMeasure_ID);
            this.HasOptional(t => t.InformationProduct)
                .WithMany(t => t.DataEntities)
                .HasForeignKey(d => d.InformationProduct_ID);

        }
    }
}
