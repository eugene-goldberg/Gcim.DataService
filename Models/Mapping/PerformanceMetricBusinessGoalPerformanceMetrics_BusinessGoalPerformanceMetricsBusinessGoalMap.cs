using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoalMap : EntityTypeConfiguration<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal>
    {
        public PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoalMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal");
            this.Property(t => t.PerformanceMetricsBusinessGoal).HasColumnName("PerformanceMetricsBusinessGoal");
            this.Property(t => t.BusinessGoalPerformanceMetrics).HasColumnName("BusinessGoalPerformanceMetrics");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessGoal)
                .WithMany(t => t.PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal)
                .HasForeignKey(d => d.PerformanceMetricsBusinessGoal);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal)
                .HasForeignKey(d => d.BusinessGoalPerformanceMetrics);

        }
    }
}
