using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BiFactMap : EntityTypeConfiguration<BiFact>
    {
        public BiFactMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BiFacts");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateRecorded).HasColumnName("DateRecorded");

            // Relationships
            this.HasMany(t => t.BiMeasures)
                .WithMany(t => t.BiFacts)
                .Map(m =>
                    {
                        m.ToTable("BiMeasureBiFacts");
                        m.MapLeftKey("BiFact_ID");
                        m.MapRightKey("BiMeasure_ID");
                    });


        }
    }
}
