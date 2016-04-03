using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ModelDifferenceMap : EntityTypeConfiguration<ModelDifference>
    {
        public ModelDifferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ModelDifferences");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ContextId).HasColumnName("ContextId");
            this.Property(t => t.Version).HasColumnName("Version");
        }
    }
}
