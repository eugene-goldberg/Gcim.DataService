using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataAssociatedMasterData_DataSourceAssociatedDataSourcesMap : EntityTypeConfiguration<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources>
    {
        public MasterDataAssociatedMasterData_DataSourceAssociatedDataSourcesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterDataAssociatedMasterData_DataSourceAssociatedDataSources");
            this.Property(t => t.AssociatedDataSources).HasColumnName("AssociatedDataSources");
            this.Property(t => t.AssociatedMasterData).HasColumnName("AssociatedMasterData");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.MasterDataAssociatedMasterData_DataSourceAssociatedDataSources)
                .HasForeignKey(d => d.AssociatedDataSources);
            this.HasOptional(t => t.MasterData)
                .WithMany(t => t.MasterDataAssociatedMasterData_DataSourceAssociatedDataSources)
                .HasForeignKey(d => d.AssociatedMasterData);

        }
    }
}
