using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class ModuleInfoMap : EntityTypeConfiguration<ModuleInfo>
    {
        public ModuleInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ModuleInfoes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.AssemblyFileName).HasColumnName("AssemblyFileName");
            this.Property(t => t.IsMain).HasColumnName("IsMain");
        }
    }
}
