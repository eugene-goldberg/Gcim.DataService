using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class KpiScorecard
    {
        public KpiScorecard()
        {
            this.KpiScorecardScorecards_KpiInstanceIndicators = new List<KpiScorecardScorecards_KpiInstanceIndicators>();
        }

        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<KpiScorecardScorecards_KpiInstanceIndicators> KpiScorecardScorecards_KpiInstanceIndicators { get; set; }
    }
}
