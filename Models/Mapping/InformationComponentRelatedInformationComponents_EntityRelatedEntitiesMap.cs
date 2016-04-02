using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class InformationComponentRelatedInformationComponents_EntityRelatedEntitiesMap : EntityTypeConfiguration<InformationComponentRelatedInformationComponents_EntityRelatedEntities>
    {
        public InformationComponentRelatedInformationComponents_EntityRelatedEntitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InformationComponentRelatedInformationComponents_EntityRelatedEntities");
            this.Property(t => t.RelatedEntities).HasColumnName("RelatedEntities");
            this.Property(t => t.RelatedInformationComponents).HasColumnName("RelatedInformationComponents");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.InformationComponentRelatedInformationComponents_EntityRelatedEntities)
                .HasForeignKey(d => d.RelatedEntities);
            this.HasOptional(t => t.InformationComponent)
                .WithMany(t => t.InformationComponentRelatedInformationComponents_EntityRelatedEntities)
                .HasForeignKey(d => d.RelatedInformationComponents);

        }
    }
}
