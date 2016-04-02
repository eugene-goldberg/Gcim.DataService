using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GambiToolUsedInGambiTools_EntityReliesOnEntitiesMap : EntityTypeConfiguration<GambiToolUsedInGambiTools_EntityReliesOnEntities>
    {
        public GambiToolUsedInGambiTools_EntityReliesOnEntitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GambiToolUsedInGambiTools_EntityReliesOnEntities");
            this.Property(t => t.ReliesOnEntities).HasColumnName("ReliesOnEntities");
            this.Property(t => t.UsedInGambiTools).HasColumnName("UsedInGambiTools");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.GambiToolUsedInGambiTools_EntityReliesOnEntities)
                .HasForeignKey(d => d.ReliesOnEntities);
            this.HasOptional(t => t.GambiTool)
                .WithMany(t => t.GambiToolUsedInGambiTools_EntityReliesOnEntities)
                .HasForeignKey(d => d.UsedInGambiTools);

        }
    }
}
