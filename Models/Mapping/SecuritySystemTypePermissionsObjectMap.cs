using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemTypePermissionsObjectMap : EntityTypeConfiguration<SecuritySystemTypePermissionsObject>
    {
        public SecuritySystemTypePermissionsObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemTypePermissionsObject");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.TargetType).HasColumnName("TargetType");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.AllowCreate).HasColumnName("AllowCreate");
            this.Property(t => t.AllowDelete).HasColumnName("AllowDelete");
            this.Property(t => t.AllowNavigate).HasColumnName("AllowNavigate");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
            this.Property(t => t.ObjectType).HasColumnName("ObjectType");
            this.Property(t => t.Owner).HasColumnName("Owner");

            // Relationships
            this.HasOptional(t => t.SecuritySystemRole)
                .WithMany(t => t.SecuritySystemTypePermissionsObjects)
                .HasForeignKey(d => d.Owner);
            this.HasOptional(t => t.XPObjectType)
                .WithMany(t => t.SecuritySystemTypePermissionsObjects)
                .HasForeignKey(d => d.ObjectType);

        }
    }
}
