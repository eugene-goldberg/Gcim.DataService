using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EntityMap : EntityTypeConfiguration<Entity>
    {
        public EntityMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Entity");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.SubjectArea).HasColumnName("SubjectArea");
            this.Property(t => t.CorrespondingLdeName).HasColumnName("CorrespondingLdeName");
            this.Property(t => t.Usage).HasColumnName("Usage");
            this.Property(t => t.Coverage).HasColumnName("Coverage");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.RelationshipType).HasColumnName("RelationshipType");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
