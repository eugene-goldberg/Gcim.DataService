using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataSourceMap : EntityTypeConfiguration<DataSource>
    {
        public DataSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataSource");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.DataSourceInstance).HasColumnName("DataSourceInstance");
            this.Property(t => t.SystemTeam).HasColumnName("SystemTeam");
            this.Property(t => t.SystemOwner).HasColumnName("SystemOwner");
            this.Property(t => t.SourceSystemName).HasColumnName("SourceSystemName");
            this.Property(t => t.SourceSystemLocation).HasColumnName("SourceSystemLocation");
            this.Property(t => t.SourceSystemNetworkSegment).HasColumnName("SourceSystemNetworkSegment");
            this.Property(t => t.SourceSystemOsType).HasColumnName("SourceSystemOsType");
            this.Property(t => t.SourceDatabaseName).HasColumnName("SourceDatabaseName");
            this.Property(t => t.SourceDatabaseType).HasColumnName("SourceDatabaseType");
            this.Property(t => t.SourceDatabaseVersion).HasColumnName("SourceDatabaseVersion");
            this.Property(t => t.IsNewRecord).HasColumnName("IsNewRecord");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
