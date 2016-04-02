using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestionsMap : EntityTypeConfiguration<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions>
    {
        public PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions");
            this.Property(t => t.RelatedBusinessQuestions).HasColumnName("RelatedBusinessQuestions");
            this.Property(t => t.RelatedPerformanceMetrics).HasColumnName("RelatedPerformanceMetrics");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessQuestion)
                .WithMany(t => t.PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions)
                .HasForeignKey(d => d.RelatedBusinessQuestions);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions)
                .HasForeignKey(d => d.RelatedPerformanceMetrics);

        }
    }
}
