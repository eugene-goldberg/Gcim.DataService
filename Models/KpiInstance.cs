using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class KpiInstance
    {
        public KpiInstance()
        {
            this.KpiDefinitions = new List<KpiDefinition>();
            this.KpiHistoryItems = new List<KpiHistoryItem>();
            this.KpiScorecardScorecards_KpiInstanceIndicators = new List<KpiScorecardScorecards_KpiInstanceIndicators>();
        }

        public System.Guid Oid { get; set; }
        public Nullable<System.DateTime> ForceMeasurementDateTime { get; set; }
        public Nullable<System.Guid> KpiDefinition { get; set; }
        public string Settings { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<KpiDefinition> KpiDefinitions { get; set; }
        public virtual KpiDefinition KpiDefinition1 { get; set; }
        public virtual ICollection<KpiHistoryItem> KpiHistoryItems { get; set; }
        public virtual ICollection<KpiScorecardScorecards_KpiInstanceIndicators> KpiScorecardScorecards_KpiInstanceIndicators { get; set; }
    }
}
