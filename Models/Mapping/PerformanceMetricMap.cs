using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricMap : EntityTypeConfiguration<PerformanceMetric>
    {
        public PerformanceMetricMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetric");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MetricCategory).HasColumnName("MetricCategory");
            this.Property(t => t.MetricName).HasColumnName("MetricName");
            this.Property(t => t.MetricDefinition).HasColumnName("MetricDefinition");
            this.Property(t => t.MetricPurpose).HasColumnName("MetricPurpose");
            this.Property(t => t.ActionableDecisions).HasColumnName("ActionableDecisions");
            this.Property(t => t.Conditions).HasColumnName("Conditions");
            this.Property(t => t.AdditionalAnalytics).HasColumnName("AdditionalAnalytics");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
