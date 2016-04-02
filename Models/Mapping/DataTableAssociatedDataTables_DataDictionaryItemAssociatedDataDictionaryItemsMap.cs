using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItemsMap : EntityTypeConfiguration<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems>
    {
        public DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItemsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems");
            this.Property(t => t.AssociatedDataDictionaryItems).HasColumnName("AssociatedDataDictionaryItems");
            this.Property(t => t.AssociatedDataTables).HasColumnName("AssociatedDataTables");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataDictionaryItem)
                .WithMany(t => t.DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems)
                .HasForeignKey(d => d.AssociatedDataDictionaryItems);
            this.HasOptional(t => t.DataTable)
                .WithMany(t => t.DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems)
                .HasForeignKey(d => d.AssociatedDataTables);

        }
    }
}
