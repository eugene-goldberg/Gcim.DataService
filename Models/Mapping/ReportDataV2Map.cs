using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ReportDataV2Map : EntityTypeConfiguration<ReportDataV2>
    {
        public ReportDataV2Map()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.ObjectTypeName)
                .HasMaxLength(512);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.ParametersObjectTypeName)
                .HasMaxLength(512);

            this.Property(t => t.PredefinedReportType)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("ReportDataV2");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.ObjectTypeName).HasColumnName("ObjectTypeName");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParametersObjectTypeName).HasColumnName("ParametersObjectTypeName");
            this.Property(t => t.IsInplaceReport).HasColumnName("IsInplaceReport");
            this.Property(t => t.PredefinedReportType).HasColumnName("PredefinedReportType");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
