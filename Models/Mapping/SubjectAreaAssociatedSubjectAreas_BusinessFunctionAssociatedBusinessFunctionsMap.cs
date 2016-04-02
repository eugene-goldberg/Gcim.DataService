using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctionsMap : EntityTypeConfiguration<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions>
    {
        public SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions");
            this.Property(t => t.AssociatedBusinessFunctions).HasColumnName("AssociatedBusinessFunctions");
            this.Property(t => t.AssociatedSubjectAreas).HasColumnName("AssociatedSubjectAreas");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedBusinessFunctions);
            this.HasOptional(t => t.SubjectArea)
                .WithMany(t => t.SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedSubjectAreas);

        }
    }
}
