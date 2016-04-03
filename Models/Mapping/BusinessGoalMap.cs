using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessGoalMap : EntityTypeConfiguration<BusinessGoal>
    {
        public BusinessGoalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessGoals");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.BusinessInitiatives)
                .WithMany(t => t.BusinessGoals)
                .Map(m =>
                    {
                        m.ToTable("BusinessInitiativeBusinessGoals");
                        m.MapLeftKey("BusinessGoal_ID");
                        m.MapRightKey("BusinessInitiative_ID");
                    });

            this.HasMany(t => t.BusinessQuestions)
                .WithMany(t => t.BusinessGoals)
                .Map(m =>
                    {
                        m.ToTable("BusinessQuestionBusinessGoals");
                        m.MapLeftKey("BusinessGoal_ID");
                        m.MapRightKey("BusinessQuestion_ID");
                    });

            this.HasMany(t => t.PerformanceMetrics)
                .WithMany(t => t.BusinessGoals)
                .Map(m =>
                    {
                        m.ToTable("PerformanceMetricBusinessGoals");
                        m.MapLeftKey("BusinessGoal_ID");
                        m.MapRightKey("PerformanceMetric_ID");
                    });


        }
    }
}
