using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class KpiHistoryItemMap : EntityTypeConfiguration<KpiHistoryItem>
    {
        public KpiHistoryItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("KpiHistoryItem");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.KpiInstance).HasColumnName("KpiInstance");
            this.Property(t => t.RangeStart).HasColumnName("RangeStart");
            this.Property(t => t.RangeEnd).HasColumnName("RangeEnd");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.KpiInstance1)
                .WithMany(t => t.KpiHistoryItems)
                .HasForeignKey(d => d.KpiInstance);

        }
    }
}
