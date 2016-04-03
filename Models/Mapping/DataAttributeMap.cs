using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataAttributeMap : EntityTypeConfiguration<DataAttribute>
    {
        public DataAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataAttributes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AttributeNmae).HasColumnName("AttributeNmae");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DataType).HasColumnName("DataType");
            this.Property(t => t.IsNullAllowed).HasColumnName("IsNullAllowed");

            // Relationships
            this.HasMany(t => t.DataDeliveryMethods)
                .WithMany(t => t.DataAttributes)
                .Map(m =>
                    {
                        m.ToTable("DataAttributeDataDeliveryMethods");
                        m.MapLeftKey("DataAttribute_ID");
                        m.MapRightKey("DataDeliveryMethod_ID");
                    });

            this.HasMany(t => t.DataEntities)
                .WithMany(t => t.DataAttributes)
                .Map(m =>
                    {
                        m.ToTable("DataEntityDataAttributes");
                        m.MapLeftKey("DataAttribute_ID");
                        m.MapRightKey("DataEntity_ID");
                    });

            this.HasMany(t => t.Udms)
                .WithMany(t => t.DataAttributes)
                .Map(m =>
                    {
                        m.ToTable("UdmDataAttributes");
                        m.MapLeftKey("DataAttribute_ID");
                        m.MapRightKey("Udm_ID");
                    });


        }
    }
}
