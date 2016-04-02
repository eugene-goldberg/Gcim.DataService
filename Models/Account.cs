using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Account
    {
        public Account()
        {
            this.DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource = new List<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource>();
        }

        public System.Guid Oid { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string IsNewRecord { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource> DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource { get; set; }
    }
}
