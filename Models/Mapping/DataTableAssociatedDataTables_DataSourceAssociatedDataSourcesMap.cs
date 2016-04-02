using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataTableAssociatedDataTables_DataSourceAssociatedDataSourcesMap : EntityTypeConfiguration<DataTableAssociatedDataTables_DataSourceAssociatedDataSources>
    {
        public DataTableAssociatedDataTables_DataSourceAssociatedDataSourcesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataTableAssociatedDataTables_DataSourceAssociatedDataSources");
            this.Property(t => t.AssociatedDataSources).HasColumnName("AssociatedDataSources");
            this.Property(t => t.AssociatedDataTables).HasColumnName("AssociatedDataTables");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.DataTableAssociatedDataTables_DataSourceAssociatedDataSources)
                .HasForeignKey(d => d.AssociatedDataSources);
            this.HasOptional(t => t.DataTable)
                .WithMany(t => t.DataTableAssociatedDataTables_DataSourceAssociatedDataSources)
                .HasForeignKey(d => d.AssociatedDataTables);

        }
    }
}
