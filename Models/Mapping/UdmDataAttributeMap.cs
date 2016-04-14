using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UdmDataAttributeMap : EntityTypeConfiguration<UdmDataAttribute>
    {
        public UdmDataAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UdmDataAttributes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.EntityAttributeName).HasColumnName("EntityAttributeName");
            this.Property(t => t.EntityAttributeDescription).HasColumnName("EntityAttributeDescription");
            this.Property(t => t.DataMartDatabaseName).HasColumnName("DataMartDatabaseName");
            this.Property(t => t.DataMartTableName).HasColumnName("DataMartTableName");
            this.Property(t => t.DataMartAttributeName).HasColumnName("DataMartAttributeName");
            this.Property(t => t.OdsDatabaseName).HasColumnName("OdsDatabaseName");
            this.Property(t => t.OdsTableName).HasColumnName("OdsTableName");
            this.Property(t => t.OdsColumnName).HasColumnName("OdsColumnName");
            this.Property(t => t.BusinessRules).HasColumnName("BusinessRules");
            this.Property(t => t.LoadProgram).HasColumnName("LoadProgram");
            this.Property(t => t.ToolInstanceName).HasColumnName("ToolInstanceName");
            this.Property(t => t.UdmFact_ID).HasColumnName("UdmFact_ID");

            // Relationships
            this.HasMany(t => t.Udms)
                .WithMany(t => t.UdmDataAttributes)
                .Map(m =>
                    {
                        m.ToTable("UdmDataAttributeUdms");
                        m.MapLeftKey("UdmDataAttribute_ID");
                        m.MapRightKey("Udm_ID");
                    });

            this.HasOptional(t => t.UdmFact)
                .WithMany(t => t.UdmDataAttributes)
                .HasForeignKey(d => d.UdmFact_ID);

        }
    }
}
