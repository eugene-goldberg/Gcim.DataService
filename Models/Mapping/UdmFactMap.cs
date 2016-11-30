using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UdmFactMap : EntityTypeConfiguration<UdmFact>
    {
        public UdmFactMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UdmFacts");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.EntityAttributeName).HasColumnName("EntityAttributeName");
            this.Property(t => t.EntityAttributeDescription).HasColumnName("EntityAttributeDescription");
            this.Property(t => t.DataMartDatabaseName).HasColumnName("DataMartDatabaseName");
            this.Property(t => t.FactTableName).HasColumnName("FactTableName");
            this.Property(t => t.DimensionTableName).HasColumnName("DimensionTableName");
            this.Property(t => t.DimensionColumnName).HasColumnName("DimensionColumnName");
            this.Property(t => t.DimensionLoadProcedure).HasColumnName("DimensionLoadProcedure");

            // Relationships
            this.HasMany(t => t.UdmMeasures)
                .WithMany(t => t.UdmFacts)
                .Map(m =>
                    {
                        m.ToTable("UdmMeasureUdmFacts");
                        m.MapLeftKey("UdmFact_ID");
                        m.MapRightKey("UdmMeasure_ID");
                    });


        }
    }
}
