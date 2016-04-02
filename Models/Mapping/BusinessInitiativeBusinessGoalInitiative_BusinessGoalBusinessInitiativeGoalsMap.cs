using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoalsMap : EntityTypeConfiguration<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals>
    {
        public BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoalsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals");
            this.Property(t => t.BusinessInitiativeGoals).HasColumnName("BusinessInitiativeGoals");
            this.Property(t => t.BusinessGoalInitiative).HasColumnName("BusinessGoalInitiative");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessGoal)
                .WithMany(t => t.BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals)
                .HasForeignKey(d => d.BusinessInitiativeGoals);
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals)
                .HasForeignKey(d => d.BusinessGoalInitiative);

        }
    }
}
