using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannelMap : EntityTypeConfiguration<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel>
    {
        public DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannelMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel");
            this.Property(t => t.MethodsDeliveryChannel).HasColumnName("MethodsDeliveryChannel");
            this.Property(t => t.DataDeliveryMethods).HasColumnName("DataDeliveryMethods");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.DataDeliveryChannel)
                .WithMany(t => t.DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel)
                .HasForeignKey(d => d.MethodsDeliveryChannel);
            this.HasOptional(t => t.DataDeliveryMethod)
                .WithMany(t => t.DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel)
                .HasForeignKey(d => d.DataDeliveryMethods);

        }
    }
}
