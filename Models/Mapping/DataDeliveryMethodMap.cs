using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryMethodMap : EntityTypeConfiguration<DataDeliveryMethod>
    {
        public DataDeliveryMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryMethods");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DataFormat).HasColumnName("DataFormat");
            this.Property(t => t.DeliveryProtocol).HasColumnName("DeliveryProtocol");

            // Relationships
            this.HasMany(t => t.DataSources)
                .WithMany(t => t.DataDeliveryMethods)
                .Map(m =>
                    {
                        m.ToTable("DataDeliveryMethodDataSources");
                        m.MapLeftKey("DataDeliveryMethod_ID");
                        m.MapRightKey("DataSource_ID");
                    });

            this.HasMany(t => t.DataEntities)
                .WithMany(t => t.DataDeliveryMethods)
                .Map(m =>
                    {
                        m.ToTable("DataEntityDataDeliveryMethods");
                        m.MapLeftKey("DataDeliveryMethod_ID");
                        m.MapRightKey("DataEntity_ID");
                    });


        }
    }
}
