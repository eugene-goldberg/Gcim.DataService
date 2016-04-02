using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSourceMap : EntityTypeConfiguration<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource>
    {
        public DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource");
            this.Property(t => t.AccountsSupportedByThisDataSource).HasColumnName("AccountsSupportedByThisDataSource");
            this.Property(t => t.DataSourcesWhichSupportThisAccount).HasColumnName("DataSourcesWhichSupportThisAccount");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource)
                .HasForeignKey(d => d.AccountsSupportedByThisDataSource);
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource)
                .HasForeignKey(d => d.DataSourcesWhichSupportThisAccount);

        }
    }
}
