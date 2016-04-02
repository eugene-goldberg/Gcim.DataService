using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ObjectFieldMap : EntityTypeConfiguration<ObjectField>
    {
        public ObjectFieldMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            this.Property(t => t.BOTypeName)
                .HasMaxLength(100);

            this.Property(t => t.BOFieldName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ObjectFields");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.BOTypeName).HasColumnName("BOTypeName");
            this.Property(t => t.BOFieldName).HasColumnName("BOFieldName");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
