using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SynonimEntitySynonims_EntitySynonimEntitiesMap : EntityTypeConfiguration<SynonimEntitySynonims_EntitySynonimEntities>
    {
        public SynonimEntitySynonims_EntitySynonimEntitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SynonimEntitySynonims_EntitySynonimEntities");
            this.Property(t => t.SynonimEntities).HasColumnName("SynonimEntities");
            this.Property(t => t.EntitySynonims).HasColumnName("EntitySynonims");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.SynonimEntitySynonims_EntitySynonimEntities)
                .HasForeignKey(d => d.SynonimEntities);
            this.HasOptional(t => t.Synonim)
                .WithMany(t => t.SynonimEntitySynonims_EntitySynonimEntities)
                .HasForeignKey(d => d.EntitySynonims);

        }
    }
}
