using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SelfHostedWebApiDataService.Models.Mapping
{
    public class SalesforcePipelineMap : EntityTypeConfiguration<SalesforcePipeline>
    {
        public SalesforcePipelineMap()
        {
            // Primary Key
            this.HasKey(t => t.Oid);

            // Properties
            // Table & Column Mappings
            this.ToTable("SalesforcePipeline");
            this.Property(t => t.Oid).HasColumnName("Oid");
            this.Property(t => t.OpportunityId).HasColumnName("OpportunityId");
            this.Property(t => t.Look).HasColumnName("Look");
            this.Property(t => t.NewStage).HasColumnName("NewStage");
            this.Property(t => t.TotalAcv).HasColumnName("TotalAcv");
            this.Property(t => t.OpportunityName).HasColumnName("OpportunityName");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.OpportunityOwner).HasColumnName("OpportunityOwner");
            this.Property(t => t.DecisionDate).HasColumnName("DecisionDate");
            this.Property(t => t.Stage).HasColumnName("Stage");
            this.Property(t => t.Industry).HasColumnName("Industry");
            this.Property(t => t.CscRegion).HasColumnName("CscRegion");
            this.Property(t => t.DealScope).HasColumnName("DealScope");
            this.Property(t => t.AccountType).HasColumnName("AccountType");
            this.Property(t => t.OpportunityRecordType).HasColumnName("OpportunityRecordType");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.RevenueStartDate).HasColumnName("RevenueStartDate");
            this.Property(t => t.RevenueTerm).HasColumnName("RevenueTerm");
            this.Property(t => t.TotalContractValueConverted).HasColumnName("TotalContractValueConverted");
            this.Property(t => t.CloseDate).HasColumnName("CloseDate");
            this.Property(t => t.ProposalSubmissionDate).HasColumnName("ProposalSubmissionDate");
            this.Property(t => t.ProbabilityPercentage).HasColumnName("ProbabilityPercentage");
            this.Property(t => t.FiscalYear).HasColumnName("FiscalYear");
            this.Property(t => t.FiscalQuerter).HasColumnName("FiscalQuerter");
            this.Property(t => t.OpportunityStartDate).HasColumnName("OpportunityStartDate");
            this.Property(t => t.StrategicGrowthApprovedDeal).HasColumnName("StrategicGrowthApprovedDeal");
            this.Property(t => t.DateQualified).HasColumnName("DateQualified");
            this.Property(t => t.DownselectedToOneDate).HasColumnName("DownselectedToOneDate");
            this.Property(t => t.OpportunityDealComplexity).HasColumnName("OpportunityDealComplexity");
            this.Property(t => t.NextStepsAndStatus).HasColumnName("NextStepsAndStatus");
            this.Property(t => t.BigDataTcv).HasColumnName("BigDataTcv");
            this.Property(t => t.CloudTcv).HasColumnName("CloudTcv");
            this.Property(t => t.CyberTcv).HasColumnName("CyberTcv");
            this.Property(t => t.GbsTcv).HasColumnName("GbsTcv");
            this.Property(t => t.GisTcv).HasColumnName("GisTcv");
            this.Property(t => t.GisAcv).HasColumnName("GisAcv");
            this.Property(t => t.DataCenterTcv).HasColumnName("DataCenterTcv");
            this.Property(t => t.PlatformTcv).HasColumnName("PlatformTcv");
            this.Property(t => t.ServiceManagementTcv).HasColumnName("ServiceManagementTcv");
            this.Property(t => t.WorkplaceTcv).HasColumnName("WorkplaceTcv");
            this.Property(t => t.NumberOfOfferings).HasColumnName("NumberOfOfferings");
            this.Property(t => t.AllOfferingNames).HasColumnName("AllOfferingNames");
            this.Property(t => t.OptimisticLockField).HasColumnName("OptimisticLockField");
            this.Property(t => t.GCRecord).HasColumnName("GCRecord");
        }
    }
}
