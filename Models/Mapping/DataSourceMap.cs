using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataSourceMap : EntityTypeConfiguration<DataSource>
    {
        public DataSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataSources");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.SourceSystemName).HasColumnName("SourceSystemName");
            this.Property(t => t.SourceSystemOwner).HasColumnName("SourceSystemOwner");
            this.Property(t => t.SourceSystemLocation).HasColumnName("SourceSystemLocation");
            this.Property(t => t.SourceSystemTeam).HasColumnName("SourceSystemTeam");
            this.Property(t => t.SourceSystemNetworkSegment).HasColumnName("SourceSystemNetworkSegment");
            this.Property(t => t.SourceSystemOsType).HasColumnName("SourceSystemOsType");
            this.Property(t => t.SourceDatabaseName).HasColumnName("SourceDatabaseName");
            this.Property(t => t.SourceDatabaseType).HasColumnName("SourceDatabaseType");
            this.Property(t => t.SourceDatabaseVersion).HasColumnName("SourceDatabaseVersion");
            this.Property(t => t.UdmFact_ID).HasColumnName("UdmFact_ID");

            // Relationships
            this.HasMany(t => t.Employees)
                .WithMany(t => t.DataSources)
                .Map(m =>
                    {
                        m.ToTable("DataSourceEmployees");
                        m.MapLeftKey("DataSource_ID");
                        m.MapRightKey("Employee_ID");
                    });

            this.HasMany(t => t.Governances)
                .WithMany(t => t.DataSources)
                .Map(m =>
                    {
                        m.ToTable("GovernanceDataSources");
                        m.MapLeftKey("DataSource_ID");
                        m.MapRightKey("Governance_ID");
                    });

            this.HasMany(t => t.MasterDatas)
                .WithMany(t => t.DataSources)
                .Map(m =>
                    {
                        m.ToTable("MasterDataDataSources");
                        m.MapLeftKey("DataSource_ID");
                        m.MapRightKey("MasterData_ID");
                    });

            this.HasMany(t => t.PerformanceMetrics)
                .WithMany(t => t.DataSources)
                .Map(m =>
                    {
                        m.ToTable("PerformanceMetricDataSources");
                        m.MapLeftKey("DataSource_ID");
                        m.MapRightKey("PerformanceMetric_ID");
                    });

            this.HasMany(t => t.SourceTools)
                .WithMany(t => t.DataSources)
                .Map(m =>
                    {
                        m.ToTable("SourceToolDataSources");
                        m.MapLeftKey("DataSource_ID");
                        m.MapRightKey("SourceTool_ID");
                    });

            this.HasOptional(t => t.UdmFact)
                .WithMany(t => t.DataSources)
                .HasForeignKey(d => d.UdmFact_ID);

        }
    }
}
