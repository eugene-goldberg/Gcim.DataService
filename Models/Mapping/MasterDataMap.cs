using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataMap : EntityTypeConfiguration<MasterData>
    {
        public MasterDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterDatas");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MasterDataEntityName).HasColumnName("MasterDataEntityName");
            this.Property(t => t.MasterDataAttributeName).HasColumnName("MasterDataAttributeName");
            this.Property(t => t.MasterDataAuthoritativeSystemName).HasColumnName("MasterDataAuthoritativeSystemName");
            this.Property(t => t.MasterDataSourceLink).HasColumnName("MasterDataSourceLink");

            // Relationships
            this.HasMany(t => t.SourceTools)
                .WithMany(t => t.MasterDatas)
                .Map(m =>
                    {
                        m.ToTable("SourceToolMasterDatas");
                        m.MapLeftKey("MasterData_ID");
                        m.MapRightKey("SourceTool_ID");
                    });


        }
    }
}
