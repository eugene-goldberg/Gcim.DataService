using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EntityOwnedEntities_EmployeeEntityOwnersMap : EntityTypeConfiguration<EntityOwnedEntities_EmployeeEntityOwners>
    {
        public EntityOwnedEntities_EmployeeEntityOwnersMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntityOwnedEntities_EmployeeEntityOwners");
            this.Property(t => t.EntityOwners).HasColumnName("EntityOwners");
            this.Property(t => t.OwnedEntities).HasColumnName("OwnedEntities");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.EntityOwnedEntities_EmployeeEntityOwners)
                .HasForeignKey(d => d.EntityOwners);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.EntityOwnedEntities_EmployeeEntityOwners)
                .HasForeignKey(d => d.OwnedEntities);

        }
    }
}
