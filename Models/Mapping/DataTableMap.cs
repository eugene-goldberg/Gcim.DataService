using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataTableMap : EntityTypeConfiguration<DataTable>
    {
        public DataTableMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataTable");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
