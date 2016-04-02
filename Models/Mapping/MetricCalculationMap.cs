using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class MetricCalculationMap : EntityTypeConfiguration<MetricCalculation>
    {
        public MetricCalculationMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("MetricCalculation");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.CalculationName).HasColumnName("CalculationName");
            this.Property(t => t.Definition).HasColumnName("Definition");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
