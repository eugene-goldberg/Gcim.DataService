using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Roles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsAdministrative).HasColumnName("IsAdministrative");
            this.Property(t => t.CanEditModel).HasColumnName("CanEditModel");

            // Relationships
            this.HasMany(t => t.Roles1)
                .WithMany(t => t.Roles)
                .Map(m =>
                    {
                        m.ToTable("RoleRoles");
                        m.MapLeftKey("Role_ID");
                        m.MapRightKey("Role_ID1");
                    });

            this.HasMany(t => t.Users)
                .WithMany(t => t.Roles)
                .Map(m =>
                    {
                        m.ToTable("UserRoles");
                        m.MapLeftKey("Role_ID");
                        m.MapRightKey("User_ID");
                    });


        }
    }
}
