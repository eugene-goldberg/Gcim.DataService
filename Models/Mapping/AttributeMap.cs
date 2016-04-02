using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class AttributeMap : EntityTypeConfiguration<Attribute>
    {
        public AttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Attribute");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.AttributeName).HasColumnName("AttributeName");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
