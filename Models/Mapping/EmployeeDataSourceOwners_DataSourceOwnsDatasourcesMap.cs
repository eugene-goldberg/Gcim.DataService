using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EmployeeDataSourceOwners_DataSourceOwnsDatasourcesMap : EntityTypeConfiguration<EmployeeDataSourceOwners_DataSourceOwnsDatasources>
    {
        public EmployeeDataSourceOwners_DataSourceOwnsDatasourcesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EmployeeDataSourceOwners_DataSourceOwnsDatasources");
            this.Property(t => t.OwnsDatasources).HasColumnName("OwnsDatasources");
            this.Property(t => t.DataSourceOwners).HasColumnName("DataSourceOwners");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.EmployeeDataSourceOwners_DataSourceOwnsDatasources)
                .HasForeignKey(d => d.OwnsDatasources);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.EmployeeDataSourceOwners_DataSourceOwnsDatasources)
                .HasForeignKey(d => d.DataSourceOwners);

        }
    }
}
