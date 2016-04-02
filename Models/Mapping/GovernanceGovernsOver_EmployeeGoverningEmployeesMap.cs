using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GovernanceGovernsOver_EmployeeGoverningEmployeesMap : EntityTypeConfiguration<GovernanceGovernsOver_EmployeeGoverningEmployees>
    {
        public GovernanceGovernsOver_EmployeeGoverningEmployeesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GovernanceGovernsOver_EmployeeGoverningEmployees");
            this.Property(t => t.GoverningEmployees).HasColumnName("GoverningEmployees");
            this.Property(t => t.GovernsOver).HasColumnName("GovernsOver");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.GovernanceGovernsOver_EmployeeGoverningEmployees)
                .HasForeignKey(d => d.GoverningEmployees);
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.GovernanceGovernsOver_EmployeeGoverningEmployees)
                .HasForeignKey(d => d.GovernsOver);

        }
    }
}
