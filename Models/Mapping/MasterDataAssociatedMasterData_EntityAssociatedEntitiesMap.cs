using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MasterDataAssociatedMasterData_EntityAssociatedEntitiesMap : EntityTypeConfiguration<MasterDataAssociatedMasterData_EntityAssociatedEntities>
    {
        public MasterDataAssociatedMasterData_EntityAssociatedEntitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MasterDataAssociatedMasterData_EntityAssociatedEntities");
            this.Property(t => t.AssociatedEntities).HasColumnName("AssociatedEntities");
            this.Property(t => t.AssociatedMasterData).HasColumnName("AssociatedMasterData");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.MasterDataAssociatedMasterData_EntityAssociatedEntities)
                .HasForeignKey(d => d.AssociatedEntities);
            this.HasOptional(t => t.MasterData)
                .WithMany(t => t.MasterDataAssociatedMasterData_EntityAssociatedEntities)
                .HasForeignKey(d => d.AssociatedMasterData);

        }
    }
}
