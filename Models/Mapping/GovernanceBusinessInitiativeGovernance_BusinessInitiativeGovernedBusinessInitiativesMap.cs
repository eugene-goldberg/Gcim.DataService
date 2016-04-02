using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiativesMap : EntityTypeConfiguration<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives>
    {
        public GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives");
            this.Property(t => t.GovernedBusinessInitiatives).HasColumnName("GovernedBusinessInitiatives");
            this.Property(t => t.BusinessInitiativeGovernance).HasColumnName("BusinessInitiativeGovernance");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives)
                .HasForeignKey(d => d.GovernedBusinessInitiatives);
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives)
                .HasForeignKey(d => d.BusinessInitiativeGovernance);

        }
    }
}
