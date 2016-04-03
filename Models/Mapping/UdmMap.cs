using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class UdmMap : EntityTypeConfiguration<Udm>
    {
        public UdmMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Udms");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.InstanceName).HasColumnName("InstanceName");
        }
    }
}
