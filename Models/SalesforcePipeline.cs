using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SalesforcePipeline
    {
        public System.Guid Oid { get; set; }
        public string OpportunityId { get; set; }
        public string Look { get; set; }
        public string NewStage { get; set; }
        public Nullable<double> TotalAcv { get; set; }
        public string OpportunityName { get; set; }
        public string AccountName { get; set; }
        public string OpportunityOwner { get; set; }
        public Nullable<System.DateTime> DecisionDate { get; set; }
        public string Stage { get; set; }
        public string Industry { get; set; }
        public string CscRegion { get; set; }
        public string DealScope { get; set; }
        public string AccountType { get; set; }
        public string OpportunityRecordType { get; set; }
        public string Scope { get; set; }
        public Nullable<System.DateTime> RevenueStartDate { get; set; }
        public string RevenueTerm { get; set; }
        public Nullable<double> TotalContractValueConverted { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> ProposalSubmissionDate { get; set; }
        public Nullable<double> ProbabilityPercentage { get; set; }
        public string FiscalYear { get; set; }
        public string FiscalQuerter { get; set; }
        public Nullable<System.DateTime> OpportunityStartDate { get; set; }
        public string StrategicGrowthApprovedDeal { get; set; }
        public Nullable<System.DateTime> DateQualified { get; set; }
        public Nullable<System.DateTime> DownselectedToOneDate { get; set; }
        public string OpportunityDealComplexity { get; set; }
        public string NextStepsAndStatus { get; set; }
        public Nullable<double> BigDataTcv { get; set; }
        public Nullable<double> CloudTcv { get; set; }
        public Nullable<double> CyberTcv { get; set; }
        public Nullable<double> GbsTcv { get; set; }
        public Nullable<double> GisTcv { get; set; }
        public Nullable<double> GisAcv { get; set; }
        public Nullable<double> DataCenterTcv { get; set; }
        public Nullable<double> PlatformTcv { get; set; }
        public Nullable<double> ServiceManagementTcv { get; set; }
        public Nullable<double> WorkplaceTcv { get; set; }
        public Nullable<int> NumberOfOfferings { get; set; }
        public string AllOfferingNames { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    }
}
