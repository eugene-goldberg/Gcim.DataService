using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataMap : EntityTypeConfiguration<MasterData>
    {
        public MasterDataMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterData");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MasterDataEntityName).HasColumnName("MasterDataEntityName");
            this.Property(t => t.MasterDataElementName).HasColumnName("MasterDataElementName");
            this.Property(t => t.MasterDataAuthoritativeSystemName).HasColumnName("MasterDataAuthoritativeSystemName");
            this.Property(t => t.MasterDataLink).HasColumnName("MasterDataLink");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
