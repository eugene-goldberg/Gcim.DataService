using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EntityAttributeEntities_AttributeEntityAttributesMap : EntityTypeConfiguration<EntityAttributeEntities_AttributeEntityAttributes>
    {
        public EntityAttributeEntities_AttributeEntityAttributesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntityAttributeEntities_AttributeEntityAttributes");
            this.Property(t => t.EntityAttributes).HasColumnName("EntityAttributes");
            this.Property(t => t.AttributeEntities).HasColumnName("AttributeEntities");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Attribute)
                .WithMany(t => t.EntityAttributeEntities_AttributeEntityAttributes)
                .HasForeignKey(d => d.EntityAttributes);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.EntityAttributeEntities_AttributeEntityAttributes)
                .HasForeignKey(d => d.AttributeEntities);

        }
    }
}
