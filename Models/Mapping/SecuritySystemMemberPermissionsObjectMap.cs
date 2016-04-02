using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemMemberPermissionsObjectMap : EntityTypeConfiguration<SecuritySystemMemberPermissionsObject>
    {
        public SecuritySystemMemberPermissionsObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemMemberPermissionsObject");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Members).HasColumnName("Members");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.Owner).HasColumnName("Owner");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.SecuritySystemTypePermissionsObject)
                .WithMany(t => t.SecuritySystemMemberPermissionsObjects)
                .HasForeignKey(d => d.Owner);

        }
    }
}
