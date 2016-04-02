using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Account");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.IsNewRecord).HasColumnName("IsNewRecord");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
