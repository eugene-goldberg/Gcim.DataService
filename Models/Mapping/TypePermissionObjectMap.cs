using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class TypePermissionObjectMap : EntityTypeConfiguration<TypePermissionObject>
    {
        public TypePermissionObjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TypePermissionObjects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AllowRead).HasColumnName("AllowRead");
            this.Property(t => t.AllowWrite).HasColumnName("AllowWrite");
            this.Property(t => t.AllowCreate).HasColumnName("AllowCreate");
            this.Property(t => t.AllowDelete).HasColumnName("AllowDelete");
            this.Property(t => t.AllowNavigate).HasColumnName("AllowNavigate");
            this.Property(t => t.TargetTypeFullName).HasColumnName("TargetTypeFullName");
            this.Property(t => t.Role_ID).HasColumnName("Role_ID");

            // Relationships
            this.HasOptional(t => t.Role)
                .WithMany(t => t.TypePermissionObjects)
                .HasForeignKey(d => d.Role_ID);

        }
    }
}
