using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricMockupForMetric_MetricMockupMetricMockupsMap : EntityTypeConfiguration<PerformanceMetricMockupForMetric_MetricMockupMetricMockups>
    {
        public PerformanceMetricMockupForMetric_MetricMockupMetricMockupsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricMockupForMetric_MetricMockupMetricMockups");
            this.Property(t => t.MetricMockups).HasColumnName("MetricMockups");
            this.Property(t => t.MockupForMetric).HasColumnName("MockupForMetric");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.MetricMockup)
                .WithMany(t => t.PerformanceMetricMockupForMetric_MetricMockupMetricMockups)
                .HasForeignKey(d => d.MetricMockups);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricMockupForMetric_MetricMockupMetricMockups)
                .HasForeignKey(d => d.MockupForMetric);

        }
    }
}
