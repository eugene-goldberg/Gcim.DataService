using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataAssociatedMasterData_GambiToolAssociatedGambiToolsMap : EntityTypeConfiguration<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools>
    {
        public MasterDataAssociatedMasterData_GambiToolAssociatedGambiToolsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools");
            this.Property(t => t.AssociatedGambiTools).HasColumnName("AssociatedGambiTools");
            this.Property(t => t.AssociatedMasterData).HasColumnName("AssociatedMasterData");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.GambiTool)
                .WithMany(t => t.MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools)
                .HasForeignKey(d => d.AssociatedGambiTools);
            this.HasOptional(t => t.MasterData)
                .WithMany(t => t.MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools)
                .HasForeignKey(d => d.AssociatedMasterData);

        }
    }
}
