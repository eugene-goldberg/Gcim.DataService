using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class DataDeliveryActivityMap : EntityTypeConfiguration<DataDeliveryActivity>
    {
        public DataDeliveryActivityMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("DataDeliveryActivity");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.DateRecorded).HasColumnName("DateRecorded");
            this.Property(t => t.DataDescription).HasColumnName("DataDescription");
            this.Property(t => t.Activity).HasColumnName("Activity");
            this.Property(t => t.DataSource).HasColumnName("DataSource");
            this.Property(t => t.SourceDataFormat).HasColumnName("SourceDataFormat");
            this.Property(t => t.TargetDataFormat).HasColumnName("TargetDataFormat");
            this.Property(t => t.TargetName).HasColumnName("TargetName");
            this.Property(t => t.PersonPerformingActivity).HasColumnName("PersonPerformingActivity");
            this.Property(t => t.ActivityStartDate).HasColumnName("ActivityStartDate");
            this.Property(t => t.ActivityEndDate).HasColumnName("ActivityEndDate");
            this.Property(t => t.CurrentStatus).HasColumnName("CurrentStatus");
            this.Property(t => t.NumberOfRecordsLoaded).HasColumnName("NumberOfRecordsLoaded");
            this.Property(t => t.TotalNumberOfRecordsInTheTarget).HasColumnName("TotalNumberOfRecordsInTheTarget");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
