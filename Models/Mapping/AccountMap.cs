using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CommonDataService.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountID);

            // Properties
            this.Property(t => t.AccountID)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Accounts");
            this.Property(t => t.AccountID).HasColumnName("AccountID");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.ParentAccountId).HasColumnName("ParentAccountId");
            this.Property(t => t.ParentAccountName).HasColumnName("ParentAccountName");
            this.Property(t => t.MasterAccountId).HasColumnName("MasterAccountId");
            this.Property(t => t.MasterAccountName).HasColumnName("MasterAccountName");
            this.Property(t => t.Customer).HasColumnName("Customer");
            this.Property(t => t.SnowDomainName).HasColumnName("SnowDomainName");
            this.Property(t => t.CapCode).HasColumnName("CapCode");
            this.Property(t => t.AccountTcvPotential).HasColumnName("AccountTcvPotential");
            this.Property(t => t.AccountTcvAwarded).HasColumnName("AccountTcvAwarded");
            this.Property(t => t.ContractStartDate).HasColumnName("ContractStartDate");
            this.Property(t => t.ContractExpiryDate).HasColumnName("ContractExpiryDate");
            this.Property(t => t.ContractType).HasColumnName("ContractType");
            this.Property(t => t.ContractTermInMonth).HasColumnName("ContractTermInMonth");
            this.Property(t => t.CurrentContractYear).HasColumnName("CurrentContractYear");
            this.Property(t => t.ContractBaseOptions).HasColumnName("ContractBaseOptions");
            this.Property(t => t.SfdcIdNumber).HasColumnName("SfdcIdNumber");
            this.Property(t => t.HasServiceLevelAgreements).HasColumnName("HasServiceLevelAgreements");
            this.Property(t => t.HasContractualReportingRequirements).HasColumnName("HasContractualReportingRequirements");
            this.Property(t => t.AccountFinancialsParentFamily).HasColumnName("AccountFinancialsParentFamily");
            this.Property(t => t.PaymentTerms).HasColumnName("PaymentTerms");
            this.Property(t => t.SecurityRestrictions).HasColumnName("SecurityRestrictions");
            this.Property(t => t.WorkScope).HasColumnName("WorkScope");
            this.Property(t => t.AccountStatus).HasColumnName("AccountStatus");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.AccountIndustry).HasColumnName("AccountIndustry");
            this.Property(t => t.AccountCountry).HasColumnName("AccountCountry");
            this.Property(t => t.AccountRegion).HasColumnName("AccountRegion");
            this.Property(t => t.PrimaryDeliveryRegion).HasColumnName("PrimaryDeliveryRegion");
            this.Property(t => t.OedRegion).HasColumnName("OedRegion");
            this.Property(t => t.LeadOffering).HasColumnName("LeadOffering");
            this.Property(t => t.AccountProgram_AccountProgramID).HasColumnName("AccountProgram_AccountProgramID");
            this.Property(t => t.AccountRolePerson_AccountRolePersonID).HasColumnName("AccountRolePerson_AccountRolePersonID");

            // Relationships
            this.HasMany(t => t.Services)
                .WithMany(t => t.Accounts)
                .Map(m =>
                    {
                        m.ToTable("ServiceAccounts");
                        m.MapLeftKey("Account_AccountID");
                        m.MapRightKey("Service_ServiceID");
                    });

            this.HasMany(t => t.Tools)
                .WithMany(t => t.Accounts)
                .Map(m =>
                    {
                        m.ToTable("ToolAccounts");
                        m.MapLeftKey("Account_AccountID");
                        m.MapRightKey("Tool_ID");
                    });

            this.HasOptional(t => t.AccountProgram)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.AccountProgram_AccountProgramID);
            this.HasOptional(t => t.AccountRolePerson)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.AccountRolePerson_AccountRolePersonID);

        }
    }
}
