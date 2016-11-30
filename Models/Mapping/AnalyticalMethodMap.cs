using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class AnalyticalMethodMap : EntityTypeConfiguration<AnalyticalMethod>
    {
        public AnalyticalMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AnalyticalMethods");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MethodName).HasColumnName("MethodName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
            this.Property(t => t.InformationProduct_ID).HasColumnName("InformationProduct_ID");

            // Relationships
            this.HasMany(t => t.BusinessEntities)
                .WithMany(t => t.AnalyticalMethods)
                .Map(m =>
                    {
                        m.ToTable("BusinessEntityAnalyticalMethods");
                        m.MapLeftKey("AnalyticalMethod_ID");
                        m.MapRightKey("BusinessEntity_ID");
                    });

            this.HasMany(t => t.PerformanceMetrics)
                .WithMany(t => t.AnalyticalMethods)
                .Map(m =>
                    {
                        m.ToTable("PerformanceMetricAnalyticalMethods");
                        m.MapLeftKey("AnalyticalMethod_ID");
                        m.MapRightKey("PerformanceMetric_ID");
                    });

            this.HasOptional(t => t.InformationProduct)
                .WithMany(t => t.AnalyticalMethods)
                .HasForeignKey(d => d.InformationProduct_ID);

        }
    }
}
