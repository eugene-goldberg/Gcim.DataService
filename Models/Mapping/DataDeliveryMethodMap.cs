using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryMethodMap : EntityTypeConfiguration<DataDeliveryMethod>
    {
        public DataDeliveryMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryMethod");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MethodName).HasColumnName("MethodName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DataFormat).HasColumnName("DataFormat");
            this.Property(t => t.DeliveryProtocol).HasColumnName("DeliveryProtocol");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
