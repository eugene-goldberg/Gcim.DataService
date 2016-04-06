using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataAttributeMap : EntityTypeConfiguration<DataAttribute>
    {
        public DataAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataAttributes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UdmDataEntityAttributeName).HasColumnName("UdmDataEntityAttributeName");
            this.Property(t => t.SourceTableName).HasColumnName("SourceTableName");
            this.Property(t => t.SourceColumnName).HasColumnName("SourceColumnName");
            this.Property(t => t.SourceColumnLength).HasColumnName("SourceColumnLength");
            this.Property(t => t.OdsTableName).HasColumnName("OdsTableName");
            this.Property(t => t.OdsColumnName).HasColumnName("OdsColumnName");
            this.Property(t => t.OdsColumnType).HasColumnName("OdsColumnType");
            this.Property(t => t.OdsColumnLength).HasColumnName("OdsColumnLength");
            this.Property(t => t.Transformation).HasColumnName("Transformation");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.BiFact_ID).HasColumnName("BiFact_ID");

            // Relationships
            this.HasMany(t => t.DataEntities)
                .WithMany(t => t.DataAttributes)
                .Map(m =>
                    {
                        m.ToTable("DataAttributeDataEntities");
                        m.MapLeftKey("DataAttribute_ID");
                        m.MapRightKey("DataEntity_ID");
                    });

            this.HasMany(t => t.Udms)
                .WithMany(t => t.DataAttributes)
                .Map(m =>
                    {
                        m.ToTable("UdmDataAttributes");
                        m.MapLeftKey("DataAttribute_ID");
                        m.MapRightKey("Udm_ID");
                    });

            this.HasOptional(t => t.BiFact)
                .WithMany(t => t.DataAttributes)
                .HasForeignKey(d => d.BiFact_ID);

        }
    }
}
