using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Account
    {
        public Account()
        {
            this.AccountAlias = new List<AccountAlia>();
            this.Services = new List<Service>();
            this.Tools = new List<Tool>();
        }

        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string ParentAccountId { get; set; }
        public string ParentAccountName { get; set; }
        public string MasterAccountId { get; set; }
        public string MasterAccountName { get; set; }
        public string Customer { get; set; }
        public string SnowDomainName { get; set; }
        public string CapCode { get; set; }
        public double AccountTcvPotential { get; set; }
        public double AccountTcvAwarded { get; set; }
        public System.DateTime ContractStartDate { get; set; }
        public System.DateTime ContractExpiryDate { get; set; }
        public string ContractType { get; set; }
        public double ContractTermInMonth { get; set; }
        public int CurrentContractYear { get; set; }
        public string ContractBaseOptions { get; set; }
        public string SfdcIdNumber { get; set; }
        public bool HasServiceLevelAgreements { get; set; }
        public bool HasContractualReportingRequirements { get; set; }
        public string AccountFinancialsParentFamily { get; set; }
        public string PaymentTerms { get; set; }
        public string SecurityRestrictions { get; set; }
        public string WorkScope { get; set; }
        public string AccountStatus { get; set; }
        public string Comments { get; set; }
        public string AccountIndustry { get; set; }
        public string AccountCountry { get; set; }
        public string AccountRegion { get; set; }
        public string PrimaryDeliveryRegion { get; set; }
        public string OedRegion { get; set; }
        public string LeadOffering { get; set; }
        public Nullable<int> AccountProgram_AccountProgramID { get; set; }
        public Nullable<int> AccountRolePerson_AccountRolePersonID { get; set; }
        public virtual ICollection<AccountAlia> AccountAlias { get; set; }
        public virtual AccountProgram AccountProgram { get; set; }
        public virtual AccountRolePerson AccountRolePerson { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}
