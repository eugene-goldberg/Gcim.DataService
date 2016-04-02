using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDiscoveryMethodMap : EntityTypeConfiguration<DataDiscoveryMethod>
    {
        public DataDiscoveryMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDiscoveryMethod");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MethodName).HasColumnName("MethodName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
