using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethodsMap : EntityTypeConfiguration<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods>
    {
        public PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethodsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods");
            this.Property(t => t.PerformanceMetricsDataDiscoveryMethods).HasColumnName("PerformanceMetricsDataDiscoveryMethods");
            this.Property(t => t.DataDiscoveryMethodPerformanceMetrics).HasColumnName("DataDiscoveryMethodPerformanceMetrics");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataDiscoveryMethod)
                .WithMany(t => t.PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods)
                .HasForeignKey(d => d.PerformanceMetricsDataDiscoveryMethods);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods)
                .HasForeignKey(d => d.DataDiscoveryMethodPerformanceMetrics);

        }
    }
}
