using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTrackedMap : EntityTypeConfiguration<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked>
    {
        public PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTrackedMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked");
            this.Property(t => t.PerformanceMetricBeingTracked).HasColumnName("PerformanceMetricBeingTracked");
            this.Property(t => t.PerformanceMetricsTrackingMethods).HasColumnName("PerformanceMetricsTrackingMethods");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked)
                .HasForeignKey(d => d.PerformanceMetricBeingTracked);
            this.HasOptional(t => t.PerformanceMetricTrackingMethod)
                .WithMany(t => t.PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked)
                .HasForeignKey(d => d.PerformanceMetricsTrackingMethods);

        }
    }
}
