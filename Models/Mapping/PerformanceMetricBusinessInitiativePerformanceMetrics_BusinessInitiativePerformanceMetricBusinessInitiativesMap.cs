using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiativesMap : EntityTypeConfiguration<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives>
    {
        public PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives");
            this.Property(t => t.PerformanceMetricBusinessInitiatives).HasColumnName("PerformanceMetricBusinessInitiatives");
            this.Property(t => t.BusinessInitiativePerformanceMetrics).HasColumnName("BusinessInitiativePerformanceMetrics");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives)
                .HasForeignKey(d => d.PerformanceMetricBusinessInitiatives);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives)
                .HasForeignKey(d => d.BusinessInitiativePerformanceMetrics);

        }
    }
}
