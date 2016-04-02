using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataAssociatedMasterData_DataTableAssociatedDataTablesMap : EntityTypeConfiguration<MasterDataAssociatedMasterData_DataTableAssociatedDataTables>
    {
        public MasterDataAssociatedMasterData_DataTableAssociatedDataTablesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterDataAssociatedMasterData_DataTableAssociatedDataTables");
            this.Property(t => t.AssociatedDataTables).HasColumnName("AssociatedDataTables");
            this.Property(t => t.AssociatedMasterData).HasColumnName("AssociatedMasterData");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataTable)
                .WithMany(t => t.MasterDataAssociatedMasterData_DataTableAssociatedDataTables)
                .HasForeignKey(d => d.AssociatedDataTables);
            this.HasOptional(t => t.MasterData)
                .WithMany(t => t.MasterDataAssociatedMasterData_DataTableAssociatedDataTables)
                .HasForeignKey(d => d.AssociatedMasterData);

        }
    }
}
