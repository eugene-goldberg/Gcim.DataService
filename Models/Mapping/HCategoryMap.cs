using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class HCategoryMap : EntityTypeConfiguration<HCategory>
    {
        public HCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HCategory");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.Parent).HasColumnName("Parent");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.HCategory2)
                .WithMany(t => t.HCategory1)
                .HasForeignKey(d => d.Parent);

        }
    }
}
