using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponentsMap : EntityTypeConfiguration<SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents>
    {
        public SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponentsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents");
            this.Property(t => t.SubjectAreaInformationComponents).HasColumnName("SubjectAreaInformationComponents");
            this.Property(t => t.InformationComponentsSubjectArea).HasColumnName("InformationComponentsSubjectArea");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.InformationComponent)
                .WithMany(t => t.SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents)
                .HasForeignKey(d => d.SubjectAreaInformationComponents);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents)
                .HasForeignKey(d => d.InformationComponentsSubjectArea);

        }
    }
}
