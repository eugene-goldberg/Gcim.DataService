using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BiDimensionMap : EntityTypeConfiguration<BiDimension>
    {
        public BiDimensionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BiDimensions");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.DataMartDatabaseName).HasColumnName("DataMartDatabaseName");
            this.Property(t => t.Conformed).HasColumnName("Conformed");

            // Relationships
            this.HasMany(t => t.BiFacts)
                .WithMany(t => t.BiDimensions)
                .Map(m =>
                    {
                        m.ToTable("BiFactBiDimensions");
                        m.MapLeftKey("BiDimension_ID");
                        m.MapRightKey("BiFact_ID");
                    });

            this.HasMany(t => t.BiMeasures)
                .WithMany(t => t.BiDimensions)
                .Map(m =>
                    {
                        m.ToTable("BiMeasureBiDimensions");
                        m.MapLeftKey("BiDimension_ID");
                        m.MapRightKey("BiMeasure_ID");
                    });


        }
    }
}
