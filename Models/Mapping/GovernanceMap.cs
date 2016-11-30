using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class GovernanceMap : EntityTypeConfiguration<Governance>
    {
        public GovernanceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Governances");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.SubjectAreas)
                .WithMany(t => t.Governances)
                .Map(m =>
                    {
                        m.ToTable("GovernanceSubjectAreas");
                        m.MapLeftKey("Governance_ID");
                        m.MapRightKey("SubjectArea_ID");
                    });


        }
    }
}
