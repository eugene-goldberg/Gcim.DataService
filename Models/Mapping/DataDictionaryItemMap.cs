using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDictionaryItemMap : EntityTypeConfiguration<DataDictionaryItem>
    {
        public DataDictionaryItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDictionaryItem");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Entity).HasColumnName("Entity");
            this.Property(t => t.AttributeName).HasColumnName("AttributeName");
            this.Property(t => t.DataType).HasColumnName("DataType");
            this.Property(t => t.BusinessMeaning).HasColumnName("BusinessMeaning");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.Entity1)
                .WithMany(t => t.DataDictionaryItems)
                .HasForeignKey(d => d.Entity);

        }
    }
}
