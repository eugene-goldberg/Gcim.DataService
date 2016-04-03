using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleInitial).HasColumnName("MiddleInitial");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.FunctionalRole).HasColumnName("FunctionalRole");

            // Relationships
            this.HasMany(t => t.Governances)
                .WithMany(t => t.Employees)
                .Map(m =>
                    {
                        m.ToTable("GovernanceEmployees");
                        m.MapLeftKey("Employee_ID");
                        m.MapRightKey("Governance_ID");
                    });


        }
    }
}
