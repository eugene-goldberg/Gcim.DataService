using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunctionMap : EntityTypeConfiguration<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction>
    {
        public BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunctionMap()
        {
            // Primary Key
            this.HasKey(t => t.OID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction");
            this.Property(t => t.SponsoredByBusinessFunction).HasColumnName("SponsoredByBusinessFunction");
            this.Property(t => t.SponsoredInitiatives).HasColumnName("SponsoredInitiatives");
            this.Property(t => t.OID).HasColumnName("OID");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");

            // Relationships
            this.HasOptional(t => t.BusinessFunction)
                .WithMany(t => t.BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction)
                .HasForeignKey(d => d.SponsoredByBusinessFunction);
            this.HasOptional(t => t.BusinessInitiative)
                .WithMany(t => t.BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction)
                .HasForeignKey(d => d.SponsoredInitiatives);

        }
    }
}
