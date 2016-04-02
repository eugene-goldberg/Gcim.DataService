using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoalsMap : EntityTypeConfiguration<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals>
    {
        public BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoalsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals");
            this.Property(t => t.RelatedSubjectGoals).HasColumnName("RelatedSubjectGoals");
            this.Property(t => t.RelatedBusinessQuestions).HasColumnName("RelatedBusinessQuestions");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessGoal)
                .WithMany(t => t.BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals)
                .HasForeignKey(d => d.RelatedSubjectGoals);
            this.HasOptional(t => t.BusinessQuestion)
                .WithMany(t => t.BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals)
                .HasForeignKey(d => d.RelatedBusinessQuestions);

        }
    }
}
