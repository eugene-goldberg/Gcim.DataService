using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctionsMap : EntityTypeConfiguration<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions>
    {
        public BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions");
            this.Property(t => t.AssociatedBusinessFunctions).HasColumnName("AssociatedBusinessFunctions");
            this.Property(t => t.AssociatedBusinessGoals).HasColumnName("AssociatedBusinessGoals");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedBusinessFunctions);
            this.HasOptional(t => t.BusinessGoal)
                .WithMany(t => t.BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedBusinessGoals);

        }
    }
}
