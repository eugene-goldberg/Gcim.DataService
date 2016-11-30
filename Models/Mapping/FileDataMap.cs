using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class FileDataMap : EntityTypeConfiguration<FileData>
    {
        public FileDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FileDatas");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Content).HasColumnName("Content");
        }
    }
}
