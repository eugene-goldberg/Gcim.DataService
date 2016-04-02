using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class KpiScorecardScorecards_KpiInstanceIndicators
    {
        public Nullable<System.Guid> Indicators { get; set; }
        public Nullable<System.Guid> Scorecards { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual KpiInstance KpiInstance { get; set; }
        public virtual KpiScorecard KpiScorecard { get; set; }
    }
}
