using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannelsMap : EntityTypeConfiguration<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels>
    {
        public DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannelsMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels");
            this.Property(t => t.DataFormatChannels).HasColumnName("DataFormatChannels");
            this.Property(t => t.ChannelDataFormats).HasColumnName("ChannelDataFormats");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataDeliveryChannel)
                .WithMany(t => t.DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels)
                .HasForeignKey(d => d.DataFormatChannels);
            this.HasOptional(t => t.DataFormat)
                .WithMany(t => t.DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels)
                .HasForeignKey(d => d.ChannelDataFormats);

        }
    }
}
