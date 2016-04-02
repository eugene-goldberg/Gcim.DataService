using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiativesMap : EntityTypeConfiguration<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives>
    {
        public EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives");
            this.Property(t => t.OwnsBusinessInitiatives).HasColumnName("OwnsBusinessInitiatives");
            this.Property(t => t.BusinessInitiativeOwner).HasColumnName("BusinessInitiativeOwner");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives)
                .HasForeignKey(d => d.OwnsBusinessInitiatives);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives)
                .HasForeignKey(d => d.BusinessInitiativeOwner);

        }
    }
}
