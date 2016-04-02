using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class KpiInstanceMap : EntityTypeConfiguration<KpiInstance>
    {
        public KpiInstanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("KpiInstance");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.ForceMeasurementDateTime).HasColumnName("ForceMeasurementDateTime");
            this.Property(t => t.KpiDefinition).HasColumnName("KpiDefinition");
            this.Property(t => t.Settings).HasColumnName("Settings");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.KpiDefinition1)
                .WithMany(t => t.KpiInstances)
                .HasForeignKey(d => d.KpiDefinition);

        }
    }
}
