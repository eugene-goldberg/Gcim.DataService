using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessFunctionMap : EntityTypeConfiguration<BusinessFunction>
    {
        public BusinessFunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessFunctions");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.BusinessGoals)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("BusinessFunctionBusinessGoals");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("BusinessGoal_ID");
                    });

            this.HasMany(t => t.BusinessInitiatives)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("BusinessInitiativeBusinessFunctions");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("BusinessInitiative_ID");
                    });

            this.HasMany(t => t.BusinessQuestions)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("BusinessQuestionBusinessFunctions");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("BusinessQuestion_ID");
                    });

            this.HasMany(t => t.Employees)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("EmployeeBusinessFunctions");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("Employee_ID");
                    });

            this.HasMany(t => t.Governances)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("GovernanceBusinessFunctions");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("Governance_ID");
                    });

            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.BusinessFunctions)
                .Map(m =>
                    {
                        m.ToTable("SubjectAreaBusinessFunctions");
                        m.MapLeftKey("BusinessFunction_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });


        }
    }
}
