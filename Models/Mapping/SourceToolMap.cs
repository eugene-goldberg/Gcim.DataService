using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SourceToolMap : EntityTypeConfiguration<SourceTool>
    {
        public SourceToolMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SourceTools");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ToolName).HasColumnName("ToolName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Governance_ID).HasColumnName("Governance_ID");
            this.Property(t => t.BusinessInitiative_ID).HasColumnName("BusinessInitiative_ID");

            // Relationships
            this.HasMany(t => t.Udms)
                .WithMany(t => t.SourceTools)
                .Map(m =>
                    {
                        m.ToTable("UdmSourceTools");
                        m.MapLeftKey("SourceTool_ID");
                        m.MapRightKey("Udm_ID");
                    });

            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.SourceTools)
                .HasForeignKey(d => d.BusinessInitiative_ID);
            this.HasOptional(t => t.Governance)
                .WithMany(t => t.SourceTools)
                .HasForeignKey(d => d.Governance_ID);

        }
    }
}
