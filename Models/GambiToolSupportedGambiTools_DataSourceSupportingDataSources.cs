using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GambiToolSupportedGambiTools_DataSourceSupportingDataSources
    {
        public Nullable<System.Guid> SupportingDataSources { get; set; }
        public Nullable<System.Guid> SupportedGambiTools { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataSource DataSource { get; set; }
        public virtual GambiTool GambiTool { get; set; }
    }
}
