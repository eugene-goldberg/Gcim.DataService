using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculationsMap : EntityTypeConfiguration<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations>
    {
        public PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculationsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations");
            this.Property(t => t.PerformanceMetricCalculations).HasColumnName("PerformanceMetricCalculations");
            this.Property(t => t.MetricSupportedByThisCalculation).HasColumnName("MetricSupportedByThisCalculation");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.MetricCalculation)
                .WithMany(t => t.PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations)
                .HasForeignKey(d => d.PerformanceMetricCalculations);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations)
                .HasForeignKey(d => d.MetricSupportedByThisCalculation);

        }
    }
}
