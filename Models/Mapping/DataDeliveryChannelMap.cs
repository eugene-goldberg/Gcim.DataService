using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryChannelMap : EntityTypeConfiguration<DataDeliveryChannel>
    {
        public DataDeliveryChannelMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryChannel");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.ChannelName).HasColumnName("ChannelName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
