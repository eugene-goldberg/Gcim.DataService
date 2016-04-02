using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemRoleParentRoles_SecuritySystemRoleChildRolesMap : EntityTypeConfiguration<SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles>
    {
        public SecuritySystemRoleParentRoles_SecuritySystemRoleChildRolesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles");
            this.Property(t => t.ChildRoles).HasColumnName("ChildRoles");
            this.Property(t => t.ParentRoles).HasColumnName("ParentRoles");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.SecuritySystemRole)
                .WithMany(t => t.SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles)
                .HasForeignKey(d => d.ChildRoles);
            this.HasOptional(t => t.SecuritySystemRole1)
                .WithMany(t => t.SecuritySystemRoleParentRoles_SecuritySystemRoleChildRoles1)
                .HasForeignKey(d => d.ParentRoles);

        }
    }
}
