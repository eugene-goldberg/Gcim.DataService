using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiativesMap : EntityTypeConfiguration<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives>
    {
        public GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiativesMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives");
            this.Property(t => t.SupportsBusinessInitiatives).HasColumnName("SupportsBusinessInitiatives");
            this.Property(t => t.SupportedByGambiTools).HasColumnName("SupportedByGambiTools");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives)
                .HasForeignKey(d => d.SupportsBusinessInitiatives);
            this.HasOptional(t => t.GambiTool)
                .WithMany(t => t.GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives)
                .HasForeignKey(d => d.SupportedByGambiTools);

        }
    }
}
