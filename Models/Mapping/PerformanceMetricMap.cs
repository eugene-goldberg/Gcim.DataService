using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricMap : EntityTypeConfiguration<PerformanceMetric>
    {
        public PerformanceMetricMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetrics");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.MetricName).HasColumnName("MetricName");
            this.Property(t => t.MetricDefinition).HasColumnName("MetricDefinition");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DataEntity_ID).HasColumnName("DataEntity_ID");
            this.Property(t => t.Governance_ID).HasColumnName("Governance_ID");
            this.Property(t => t.BusinessInitiative_ID).HasColumnName("BusinessInitiative_ID");

            // Relationships
            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.PerformanceMetrics)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaPerformanceMetrics");
                        m.MapLeftKey("PerformanceMetric_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });

            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.PerformanceMetrics)
                .HasForeignKey(d => d.BusinessInitiative_ID);
            this.HasOptional(t => t.DataEntity)
                .WithMany(t => t.PerformanceMetrics)
                .HasForeignKey(d => d.DataEntity_ID);
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.PerformanceMetrics)
                .HasForeignKey(d => d.Governance_ID);

        }
    }
}
