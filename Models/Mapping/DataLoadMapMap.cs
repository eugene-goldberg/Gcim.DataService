using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataLoadMapMap : EntityTypeConfiguration<DataLoadMap>
    {
        public DataLoadMapMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataLoadMaps");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DataLoadMapName).HasColumnName("DataLoadMapName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.ImportFileName).HasColumnName("ImportFileName");
            this.Property(t => t.FieldMapsImportFile_ID).HasColumnName("FieldMapsImportFile_ID");
            this.Property(t => t.InputFile_ID).HasColumnName("InputFile_ID");

            // Relationships
            this.HasOptional(t => t.FileData)
                .WithMany(t => t.DataLoadMaps)
                .HasForeignKey(d => d.FieldMapsImportFile_ID);
            this.HasOptional(t => t.FileData1)
                .WithMany(t => t.DataLoadMaps1)
                .HasForeignKey(d => d.InputFile_ID);

        }
    }
}
