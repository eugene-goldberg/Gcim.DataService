using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MetricMockupMap : EntityTypeConfiguration<MetricMockup>
    {
        public MetricMockupMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("MetricMockup");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MockupName).HasColumnName("MockupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.MockupFile).HasColumnName("MockupFile");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.FileData)
                .WithMany(t => t.MetricMockups)
                .HasForeignKey(d => d.MockupFile);

        }
    }
}
