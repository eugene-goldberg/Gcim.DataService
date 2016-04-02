using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessInitiativeMap : EntityTypeConfiguration<BusinessInitiative>
    {
        public BusinessInitiativeMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessInitiative");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.InitiativeName).HasColumnName("InitiativeName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CurrentStatus).HasColumnName("CurrentStatus");
            this.Property(t => t.IsNewRecord).HasColumnName("IsNewRecord");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
