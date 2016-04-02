using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctionsMap : EntityTypeConfiguration<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions>
    {
        public BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctionsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions");
            this.Property(t => t.AssociatedBusinessFunctions).HasColumnName("AssociatedBusinessFunctions");
            this.Property(t => t.AssociatedBusinessQuestions).HasColumnName("AssociatedBusinessQuestions");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedBusinessFunctions);
            this.HasOptional(t => t.BusinessQuestion)
                .WithMany(t => t.BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions)
                .HasForeignKey(d => d.AssociatedBusinessQuestions);

        }
    }
}
