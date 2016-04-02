using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemObjectPermissionsObjectMap : EntityTypeConfiguration<SecuritySystemObjectPermissionsObject>
    {
        public SecuritySystemObjectPermissionsObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemObjectPermissionsObject");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.AllowDelete).HasColumnName("AllowDelete");
            this.Property(t => t.AllowNavigate).HasColumnName("AllowNavigate");
            this.Property(t => t.Owner).HasColumnName("Owner");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.SecuritySystemTypePermissionsObject)
                .WithMany(t => t.SecuritySystemObjectPermissionsObjects)
                .HasForeignKey(d => d.Owner);

        }
    }
}
