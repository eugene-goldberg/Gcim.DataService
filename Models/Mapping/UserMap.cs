using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ChangePasswordOnFirstLogon).HasColumnName("ChangePasswordOnFirstLogon");
            this.Property(t => t.StoredPassword).HasColumnName("StoredPassword");
        }
    }
}
