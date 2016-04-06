using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryChannelMap : EntityTypeConfiguration<DataDeliveryChannel>
    {
        public DataDeliveryChannelMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryChannels");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SourceSystemName).HasColumnName("SourceSystemName");
            this.Property(t => t.SourceTableName).HasColumnName("SourceTableName");
            this.Property(t => t.SourceQuery).HasColumnName("SourceQuery");
            this.Property(t => t.OdsDatabaseName).HasColumnName("OdsDatabaseName");
            this.Property(t => t.OdsTableName).HasColumnName("OdsTableName");
            this.Property(t => t.OdsProcedure).HasColumnName("OdsProcedure");

            // Relationships
            this.HasMany(t => t.DataSources)
                .WithMany(t => t.DataDeliveryChannels)
                .Map(m =>
                    {
                        m.ToTable("DataDeliveryChannelDataSources");
                        m.MapLeftKey("DataDeliveryChannel_ID");
                        m.MapRightKey("DataSource_ID");
                    });

            this.HasMany(t => t.DataEntities)
                .WithMany(t => t.DataDeliveryChannels)
                .Map(m =>
                    {
                        m.ToTable("DataEntityDataDeliveryChannels");
                        m.MapLeftKey("DataDeliveryChannel_ID");
                        m.MapRightKey("DataEntity_ID");
                    });


        }
    }
}
