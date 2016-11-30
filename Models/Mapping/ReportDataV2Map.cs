using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ReportDataV2Map : EntityTypeConfiguration<ReportDataV2>
    {
        public ReportDataV2Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ReportDataV2");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DataTypeName).HasColumnName("DataTypeName");
            this.Property(t => t.IsInplaceReport).HasColumnName("IsInplaceReport");
            this.Property(t => t.PredefinedReportTypeName).HasColumnName("PredefinedReportTypeName");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.ParametersObjectTypeName).HasColumnName("ParametersObjectTypeName");
        }
    }
}
