using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemMemberPermissionsObjectMap : EntityTypeConfiguration<SecuritySystemMemberPermissionsObject>
    {
        public SecuritySystemMemberPermissionsObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemMemberPermissionsObjects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Members).HasColumnName("Members");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.EffectiveRead).HasColumnName("EffectiveRead");
            this.Property(t => t.EffectiveWrite).HasColumnName("EffectiveWrite");
            this.Property(t => t.Owner_ID).HasColumnName("Owner_ID");

            // Relationships
            this.HasOptional(t => t.TypePermissionObject)
                .WithMany(t => t.SecuritySystemMemberPermissionsObjects)
                .HasForeignKey(d => d.Owner_ID);

        }
    }
}
