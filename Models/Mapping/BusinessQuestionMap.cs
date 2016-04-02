using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessQuestionMap : EntityTypeConfiguration<BusinessQuestion>
    {
        public BusinessQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessQuestion");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.QuestionDefinition).HasColumnName("QuestionDefinition");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.RelatedSubjectArea).HasColumnName("RelatedSubjectArea");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
