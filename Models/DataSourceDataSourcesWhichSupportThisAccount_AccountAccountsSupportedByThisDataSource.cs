using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource
    {
        public Nullable<System.Guid> AccountsSupportedByThisDataSource { get; set; }
        public Nullable<System.Guid> DataSourcesWhichSupportThisAccount { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Account Account { get; set; }
        public virtual DataSource DataSource { get; set; }
    }
}
