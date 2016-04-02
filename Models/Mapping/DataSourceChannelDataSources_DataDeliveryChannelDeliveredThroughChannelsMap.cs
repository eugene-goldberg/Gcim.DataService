using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannelsMap : EntityTypeConfiguration<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels>
    {
        public DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannelsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels");
            this.Property(t => t.DeliveredThroughChannels).HasColumnName("DeliveredThroughChannels");
            this.Property(t => t.ChannelDataSources).HasColumnName("ChannelDataSources");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataDeliveryChannel)
                .WithMany(t => t.DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels)
                .HasForeignKey(d => d.DeliveredThroughChannels);
            this.HasOptional(t => t.DataSource)
                .WithMany(t => t.DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels)
                .HasForeignKey(d => d.ChannelDataSources);

        }
    }
}
