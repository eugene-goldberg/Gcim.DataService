using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UdmDimensionMap : EntityTypeConfiguration<UdmDimension>
    {
        public UdmDimensionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UdmDimensions");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.EntityAttributeName).HasColumnName("EntityAttributeName");
            this.Property(t => t.EntityAttributeDescription).HasColumnName("EntityAttributeDescription");
            this.Property(t => t.DataMartDatabaseName).HasColumnName("DataMartDatabaseName");
            this.Property(t => t.DimensionTableName).HasColumnName("DimensionTableName");
            this.Property(t => t.DimensionColumnName).HasColumnName("DimensionColumnName");
            this.Property(t => t.DimensionLoadProcedure).HasColumnName("DimensionLoadProcedure");

            // Relationships
            this.HasMany(t => t.UdmFacts)
                .WithMany(t => t.UdmDimensions)
                .Map(m =>
                    {
                        m.ToTable("UdmFactUdmDimensions");
                        m.MapLeftKey("UdmDimension_ID");
                        m.MapRightKey("UdmFact_ID");
                    });

            this.HasMany(t => t.UdmMeasures)
                .WithMany(t => t.UdmDimensions)
                .Map(m =>
                    {
                        m.ToTable("UdmMeasureUdmDimensions");
                        m.MapLeftKey("UdmDimension_ID");
                        m.MapRightKey("UdmMeasure_ID");
                    });


        }
    }
}
