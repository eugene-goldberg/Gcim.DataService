using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class FieldMapMap : EntityTypeConfiguration<FieldMap>
    {
        public FieldMapMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            this.Property(t => t.ExcelTabName)
                .HasMaxLength(100);

            this.Property(t => t.ExcelColumnName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FieldMap");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.LoadOrderOverall).HasColumnName("LoadOrderOverall");
            this.Property(t => t.LoadOrderForThisBO).HasColumnName("LoadOrderForThisBO");
            this.Property(t => t.ExcelTabName).HasColumnName("ExcelTabName");
            this.Property(t => t.ExcelColumnName).HasColumnName("ExcelColumnName");
            this.Property(t => t.ExcelColumnPosition).HasColumnName("ExcelColumnPosition");
            this.Property(t => t.BOField).HasColumnName("BOField");
            this.Property(t => t.InputFile).HasColumnName("InputFile");
            this.Property(t => t.DataLoadMap).HasColumnName("DataLoadMap");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.DataLoadMap1)
                .WithMany(t => t.FieldMaps)
                .HasForeignKey(d => d.DataLoadMap);
            this.HasOptional(t => t.ObjectField)
                .WithMany(t => t.FieldMaps)
                .HasForeignKey(d => d.BOField);
            this.HasOptional(t => t.FileData)
                .WithMany(t => t.FieldMaps)
                .HasForeignKey(d => d.InputFile);

        }
    }
}
