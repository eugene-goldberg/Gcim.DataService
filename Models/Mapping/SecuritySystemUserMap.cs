using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemUserMap : EntityTypeConfiguration<SecuritySystemUser>
    {
        public SecuritySystemUserMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.UserName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("SecuritySystemUser");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.StoredPassword).HasColumnName("StoredPassword");
            this.Property(t => t.ChangePasswordOnFirstLogon).HasColumnName("ChangePasswordOnFirstLogon");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
            this.Property(t => t.ObjectType).HasColumnName("ObjectType");

            // Relationships
            this.HasOptional(t => t.XPObjectType)
                .WithMany(t => t.SecuritySystemUsers)
                .HasForeignKey(d => d.ObjectType);

        }
    }
}
