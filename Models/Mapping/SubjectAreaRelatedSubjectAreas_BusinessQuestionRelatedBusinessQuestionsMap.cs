using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestionsMap : EntityTypeConfiguration<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions>
    {
        public SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions");
            this.Property(t => t.RelatedBusinessQuestions).HasColumnName("RelatedBusinessQuestions");
            this.Property(t => t.RelatedSubjectAreas).HasColumnName("RelatedSubjectAreas");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessQuestion)
                .WithMany(t => t.SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions)
                .HasForeignKey(d => d.RelatedBusinessQuestions);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions)
                .HasForeignKey(d => d.RelatedSubjectAreas);

        }
    }
}
