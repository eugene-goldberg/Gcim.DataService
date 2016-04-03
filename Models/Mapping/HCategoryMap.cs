using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class HCategoryMap : EntityTypeConfiguration<HCategory>
    {
        public HCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("HCategories");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Parent_ID).HasColumnName("Parent_ID");

            // Relationships
            this.HasOptional(t => t.HCategory1)
                .WithMany(t => t.HCategories1)
                .HasForeignKey(d => d.Parent_ID);

        }
    }
}
