using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessQuestionMap : EntityTypeConfiguration<BusinessQuestion>
    {
        public BusinessQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessQuestions");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.QuestionDefinition).HasColumnName("QuestionDefinition");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.RelatedSubjectArea).HasColumnName("RelatedSubjectArea");
            this.Property(t => t.AnalyticalMethod_ID).HasColumnName("AnalyticalMethod_ID");

            // Relationships
            this.HasMany(t => t.PerformanceMetrics)
                .WithMany(t => t.BusinessQuestions)
                .Map(m =>
                    {
                        m.ToTable("BusinessQuestionPerformanceMetrics");
                        m.MapLeftKey("BusinessQuestion_ID");
                        m.MapRightKey("PerformanceMetric_ID");
                    });

            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.BusinessQuestions)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaBusinessQuestions");
                        m.MapLeftKey("BusinessQuestion_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });

            this.HasOptional(t => t.AnalyticalMethod)
                .WithMany(t => t.BusinessQuestions)
                .HasForeignKey(d => d.AnalyticalMethod_ID);

        }
    }
}
