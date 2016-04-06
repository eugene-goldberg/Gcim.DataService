using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class InformationProductMap : EntityTypeConfiguration<InformationProduct>
    {
        public InformationProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("InformationProducts");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Governance_ID).HasColumnName("Governance_ID");
            this.Property(t => t.PerformanceMetric_ID).HasColumnName("PerformanceMetric_ID");

            // Relationships
            this.HasMany(t => t.SourceTools)
                .WithMany(t => t.InformationProducts)
                .Map(m =>
                    {
                        m.ToTable("InformationProductSourceTools");
                        m.MapLeftKey("InformationProduct_ID");
                        m.MapRightKey("SourceTool_ID");
                    });

            this.HasOptional(t => t.Governance)
                .WithMany(t => t.InformationProducts)
                .HasForeignKey(d => d.Governance_ID);
            this.HasOptional(t => t.PerformanceMetric)
                .WithMany(t => t.InformationProducts)
                .HasForeignKey(d => d.PerformanceMetric_ID);

        }
    }
}
