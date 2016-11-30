using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ChangeRecordMap : EntityTypeConfiguration<ChangeRecord>
    {
        public ChangeRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ChangeRecords");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ObjectType).HasColumnName("ObjectType");
            this.Property(t => t.ObjectName).HasColumnName("ObjectName");
            this.Property(t => t.ProposedChangeContent).HasColumnName("ProposedChangeContent");
        }
    }
}
