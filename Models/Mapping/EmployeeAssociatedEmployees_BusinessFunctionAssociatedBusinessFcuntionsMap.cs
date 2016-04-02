using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntionsMap : EntityTypeConfiguration<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions>
    {
        public EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions");
            this.Property(t => t.AssociatedBusinessFcuntions).HasColumnName("AssociatedBusinessFcuntions");
            this.Property(t => t.AssociatedEmployees).HasColumnName("AssociatedEmployees");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions)
                .HasForeignKey(d => d.AssociatedBusinessFcuntions);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions)
                .HasForeignKey(d => d.AssociatedEmployees);

        }
    }
}
