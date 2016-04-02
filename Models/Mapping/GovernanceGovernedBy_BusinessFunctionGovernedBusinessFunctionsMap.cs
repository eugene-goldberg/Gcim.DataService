using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctionsMap : EntityTypeConfiguration<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions>
    {
        public GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions");
            this.Property(t => t.GovernedBusinessFunctions).HasColumnName("GovernedBusinessFunctions");
            this.Property(t => t.GovernedBy).HasColumnName("GovernedBy");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions)
                .HasForeignKey(d => d.GovernedBusinessFunctions);
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions)
                .HasForeignKey(d => d.GovernedBy);

        }
    }
}
