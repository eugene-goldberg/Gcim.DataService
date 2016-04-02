using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSourcesMap : EntityTypeConfiguration<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources>
    {
        public EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSourcesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources");
            this.Property(t => t.EntityDataSources).HasColumnName("EntityDataSources");
            this.Property(t => t.EntitiesRelyingOnThisDataSource).HasColumnName("EntitiesRelyingOnThisDataSource");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources)
                .HasForeignKey(d => d.EntityDataSources);
            this.HasOptional(t => t.Entity)
                .WithMany(t => t.EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources)
                .HasForeignKey(d => d.EntitiesRelyingOnThisDataSource);

        }
    }
}
