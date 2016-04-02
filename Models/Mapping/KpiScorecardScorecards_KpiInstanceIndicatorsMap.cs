using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class KpiScorecardScorecards_KpiInstanceIndicatorsMap : EntityTypeConfiguration<KpiScorecardScorecards_KpiInstanceIndicators>
    {
        public KpiScorecardScorecards_KpiInstanceIndicatorsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("KpiScorecardScorecards_KpiInstanceIndicators");
            this.Property(t => t.Indicators).HasColumnName("Indicators");
            this.Property(t => t.Scorecards).HasColumnName("Scorecards");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.KpiInstance)
                .WithMany(t => t.KpiScorecardScorecards_KpiInstanceIndicators)
                .HasForeignKey(d => d.Indicators);
            this.HasOptional(t => t.KpiScorecard)
                .WithMany(t => t.KpiScorecardScorecards_KpiInstanceIndicators)
                .HasForeignKey(d => d.Scorecards);

        }
    }
}
