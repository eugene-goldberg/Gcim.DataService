using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SecuritySystemObjectPermissionsObjectMap : EntityTypeConfiguration<SecuritySystemObjectPermissionsObject>
    {
        public SecuritySystemObjectPermissionsObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecuritySystemObjectPermissionsObjects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.AllowDelete).HasColumnName("AllowDelete");
            this.Property(t => t.AllowNavigate).HasColumnName("AllowNavigate");
            this.Property(t => t.EffectiveRead).HasColumnName("EffectiveRead");
            this.Property(t => t.EffectiveWrite).HasColumnName("EffectiveWrite");
            this.Property(t => t.EffectiveDelete).HasColumnName("EffectiveDelete");
            this.Property(t => t.EffectiveNavigate).HasColumnName("EffectiveNavigate");
            this.Property(t => t.Owner_ID).HasColumnName("Owner_ID");

            // Relationships
            this.HasOptional(t => t.TypePermissionObject)
                .WithMany(t => t.SecuritySystemObjectPermissionsObjects)
                .HasForeignKey(d => d.Owner_ID);

        }
    }
}
