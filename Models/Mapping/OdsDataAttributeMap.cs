using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class OdsDataAttributeMap : EntityTypeConfiguration<OdsDataAttribute>
    {
        public OdsDataAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OdsDataAttributes");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ToolInstanceName).HasColumnName("ToolInstanceName");
            this.Property(t => t.OdsDatabaseName).HasColumnName("OdsDatabaseName");
            this.Property(t => t.SourceTableName).HasColumnName("SourceTableName");
            this.Property(t => t.SourceColumnName).HasColumnName("SourceColumnName");
            this.Property(t => t.SourceColumnType).HasColumnName("SourceColumnType");
            this.Property(t => t.SourceColumnLength).HasColumnName("SourceColumnLength");
            this.Property(t => t.OdsTableName).HasColumnName("OdsTableName");
            this.Property(t => t.OdsColumnName).HasColumnName("OdsColumnName");
            this.Property(t => t.OdsColumnType).HasColumnName("OdsColumnType");
            this.Property(t => t.OdsColumnLength).HasColumnName("OdsColumnLength");
            this.Property(t => t.Transformation).HasColumnName("Transformation");
            this.Property(t => t.Notes).HasColumnName("Notes");
        }
    }
}
