using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ModelDifferenceAspectMap : EntityTypeConfiguration<ModelDifferenceAspect>
    {
        public ModelDifferenceAspectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ModelDifferenceAspects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Xml).HasColumnName("Xml");
            this.Property(t => t.Owner_ID).HasColumnName("Owner_ID");

            // Relationships
            this.HasOptional(t => t.ModelDifference)
                .WithMany(t => t.ModelDifferenceAspects)
                .HasForeignKey(d => d.Owner_ID);

        }
    }
}
