using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethodsMap : EntityTypeConfiguration<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods>
    {
        public PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethodsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods");
            this.Property(t => t.RelatedAnalythicalMethods).HasColumnName("RelatedAnalythicalMethods");
            this.Property(t => t.RelatedPerformanceMetrics).HasColumnName("RelatedPerformanceMetrics");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.AnalyticalMethod)
                .WithMany(t => t.PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods)
                .HasForeignKey(d => d.RelatedAnalythicalMethods);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods)
                .HasForeignKey(d => d.RelatedPerformanceMetrics);

        }
    }
}
