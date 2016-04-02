using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemRoleMap : EntityTypeConfiguration<SecuritySystemRole>
    {
        public SecuritySystemRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SecuritySystemRole");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
            this.Property(t => t.ObjectType).HasColumnName("ObjectType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsAdministrative).HasColumnName("IsAdministrative");
            this.Property(t => t.CanEditModel).HasColumnName("CanEditModel");

            // Relationships
            this.HasOptional(t => t.XPObjectType)
                .WithMany(t => t.SecuritySystemRoles)
                .HasForeignKey(d => d.ObjectType);

        }
    }
}
