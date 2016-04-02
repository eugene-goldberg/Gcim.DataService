using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class PerformanceMetricTrackingMethodMap : EntityTypeConfiguration<PerformanceMetricTrackingMethod>
    {
        public PerformanceMetricTrackingMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("PerformanceMetricTrackingMethod");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.MethodName).HasColumnName("MethodName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
