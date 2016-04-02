using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiativesMap : EntityTypeConfiguration<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives>
    {
        public SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives");
            this.Property(t => t.SubjectAreaBusinessInitiatives).HasColumnName("SubjectAreaBusinessInitiatives");
            this.Property(t => t.BusinessInitiativeSubjectAreas).HasColumnName("BusinessInitiativeSubjectAreas");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives)
                .HasForeignKey(d => d.SubjectAreaBusinessInitiatives);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives)
                .HasForeignKey(d => d.BusinessInitiativeSubjectAreas);

        }
    }
}
