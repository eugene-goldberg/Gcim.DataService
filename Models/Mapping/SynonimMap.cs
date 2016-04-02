using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SynonimMap : EntityTypeConfiguration<Synonim>
    {
        public SynonimMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Synonim");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.SynonimName).HasColumnName("SynonimName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
