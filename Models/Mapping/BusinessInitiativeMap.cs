using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessInitiativeMap : EntityTypeConfiguration<BusinessInitiative>
    {
        public BusinessInitiativeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessInitiatives");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasMany(t => t.Employees)
                .WithMany(t => t.BusinessInitiatives)
                .Map(m =>
                    {
                        m.ToTable("EmployeeBusinessInitiatives");
                        m.MapLeftKey("BusinessInitiative_ID");
                        m.MapRightKey("Employee_ID");
                    });

            this.HasMany(t => t.Governances)
                .WithMany(t => t.BusinessInitiatives)
                .Map(m =>
                    {
                        m.ToTable("GovernanceBusinessInitiatives");
                        m.MapLeftKey("BusinessInitiative_ID");
                        m.MapRightKey("Governance_ID");
                    });

            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.BusinessInitiatives)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaBusinessInitiatives");
                        m.MapLeftKey("BusinessInitiative_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });


        }
    }
}
