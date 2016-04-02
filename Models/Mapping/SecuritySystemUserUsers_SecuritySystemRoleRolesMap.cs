using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemUserUsers_SecuritySystemRoleRolesMap : EntityTypeConfiguration<SecuritySystemUserUsers_SecuritySystemRoleRoles>
    {
        public SecuritySystemUserUsers_SecuritySystemRoleRolesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemUserUsers_SecuritySystemRoleRoles");
            this.Property(t => t.Roles).HasColumnName("Roles");
            this.Property(t => t.Users).HasColumnName("Users");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.SecuritySystemRole)
                .WithMany(t => t.SecuritySystemUserUsers_SecuritySystemRoleRoles)
                .HasForeignKey(d => d.Roles);
            this.HasOptional(t => t.SecuritySystemUser)
                .WithMany(t => t.SecuritySystemUserUsers_SecuritySystemRoleRoles)
                .HasForeignKey(d => d.Users);

        }
    }
}
