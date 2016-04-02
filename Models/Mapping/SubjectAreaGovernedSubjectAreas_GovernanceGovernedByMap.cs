using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaGovernedSubjectAreas_GovernanceGovernedByMap : EntityTypeConfiguration<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy>
    {
        public SubjectAreaGovernedSubjectAreas_GovernanceGovernedByMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy");
            this.Property(t => t.GovernedBy).HasColumnName("GovernedBy");
            this.Property(t => t.GovernedSubjectAreas).HasColumnName("GovernedSubjectAreas");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy)
                .HasForeignKey(d => d.GovernedBy);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy)
                .HasForeignKey(d => d.GovernedSubjectAreas);

        }
    }
}
