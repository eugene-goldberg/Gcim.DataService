using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class KpiDefinitionMap : EntityTypeConfiguration<KpiDefinition>
    {
        public KpiDefinitionMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            this.Property(t => t.TargetObjectType)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Range)
                .HasMaxLength(100);

            this.Property(t => t.RangeToCompare)
                .HasMaxLength(100);

            this.Property(t => t.SuppressedSeries)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("KpiDefinition");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.TargetObjectType).HasColumnName("TargetObjectType");
            this.Property(t => t.Changed).HasColumnName("Changed");
            this.Property(t => t.KpiInstance).HasColumnName("KpiInstance");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Criteria).HasColumnName("Criteria");
            this.Property(t => t.Expression).HasColumnName("Expression");
            this.Property(t => t.GreenZone).HasColumnName("GreenZone");
            this.Property(t => t.RedZone).HasColumnName("RedZone");
            this.Property(t => t.Range).HasColumnName("Range");
            this.Property(t => t.Compare).HasColumnName("Compare");
            this.Property(t => t.RangeToCompare).HasColumnName("RangeToCompare");
            this.Property(t => t.MeasurementFrequency).HasColumnName("MeasurementFrequency");
            this.Property(t => t.MeasurementMode).HasColumnName("MeasurementMode");
            this.Property(t => t.Direction).HasColumnName("Direction");
            this.Property(t => t.ChangedOn).HasColumnName("ChangedOn");
            this.Property(t => t.SuppressedSeries).HasColumnName("SuppressedSeries");
            this.Property(t => t.EnableCustomizeRepresentation).HasColumnName("EnableCustomizeRepresentation");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");

            // Relationships
            this.HasOptional(t => t.KpiInstance1)
                .WithMany(t => t.KpiDefinitions)
                .HasForeignKey(d => d.KpiInstance);

        }
    }
}
