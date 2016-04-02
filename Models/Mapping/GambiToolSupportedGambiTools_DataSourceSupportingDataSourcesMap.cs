using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GambiToolSupportedGambiTools_DataSourceSupportingDataSourcesMap : EntityTypeConfiguration<GambiToolSupportedGambiTools_DataSourceSupportingDataSources>
    {
        public GambiToolSupportedGambiTools_DataSourceSupportingDataSourcesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GambiToolSupportedGambiTools_DataSourceSupportingDataSources");
            this.Property(t => t.SupportingDataSources).HasColumnName("SupportingDataSources");
            this.Property(t => t.SupportedGambiTools).HasColumnName("SupportedGambiTools");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.GambiToolSupportedGambiTools_DataSourceSupportingDataSources)
                .HasForeignKey(d => d.SupportingDataSources);
            this.HasOptional(t => t.GambiTool)
                .WithMany(t => t.GambiToolSupportedGambiTools_DataSourceSupportingDataSources)
                .HasForeignKey(d => d.SupportedGambiTools);

        }
    }
}
