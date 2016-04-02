using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GambiToolOwnsGambiTools_EmployeeToolOwnersMap : EntityTypeConfiguration<GambiToolOwnsGambiTools_EmployeeToolOwners>
    {
        public GambiToolOwnsGambiTools_EmployeeToolOwnersMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GambiToolOwnsGambiTools_EmployeeToolOwners");
            this.Property(t => t.ToolOwners).HasColumnName("ToolOwners");
            this.Property(t => t.OwnsGambiTools).HasColumnName("OwnsGambiTools");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.GambiToolOwnsGambiTools_EmployeeToolOwners)
                .HasForeignKey(d => d.ToolOwners);
            this.HasOptional(t => t.GambiTool)
                .WithMany(t => t.GambiToolOwnsGambiTools_EmployeeToolOwners)
                .HasForeignKey(d => d.OwnsGambiTools);

        }
    }
}
