using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class AnalysisMap : EntityTypeConfiguration<Analysis>
    {
        public AnalysisMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.ObjectTypeName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Analysis");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.DimensionPropertiesString).HasColumnName("DimensionPropertiesString");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.ObjectTypeName).HasColumnName("ObjectTypeName");
            this.Property(t => t.ChartSettingsContent).HasColumnName("ChartSettingsContent");
            this.Property(t => t.PivotGridSettingsContent).HasColumnName("PivotGridSettingsContent");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
