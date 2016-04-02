using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntitiesMap : EntityTypeConfiguration<SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities>
    {
        public SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntitiesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities");
            this.Property(t => t.SubjectAreaEntities).HasColumnName("SubjectAreaEntities");
            this.Property(t => t.EntitySubjectAreas).HasColumnName("EntitySubjectAreas");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities)
                .HasForeignKey(d => d.SubjectAreaEntities);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities)
                .HasForeignKey(d => d.EntitySubjectAreas);

        }
    }
}
