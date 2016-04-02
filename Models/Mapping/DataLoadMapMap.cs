using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataLoadMapMap : EntityTypeConfiguration<DataLoadMap>
    {
        public DataLoadMapMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataLoadMap");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.DataLoadMapName).HasColumnName("DataLoadMapName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.ImportFileName).HasColumnName("ImportFileName");
            this.Property(t => t.InputFile).HasColumnName("InputFile");
            this.Property(t => t.FieldmapsImportFile).HasColumnName("FieldmapsImportFile");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.FileData)
                .WithMany(t => t.DataLoadMaps)
                .HasForeignKey(d => d.FieldmapsImportFile);
            this.HasOptional(t => t.FileData1)
                .WithMany(t => t.DataLoadMaps1)
                .HasForeignKey(d => d.InputFile);

        }
    }
}
