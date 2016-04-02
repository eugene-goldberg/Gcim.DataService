using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class KpiHistoryItem
    {
        public System.Guid Oid { get; set; }
        public Nullable<System.Guid> KpiInstance { get; set; }
        public Nullable<System.DateTime> RangeStart { get; set; }
        public Nullable<System.DateTime> RangeEnd { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual KpiInstance KpiInstance1 { get; set; }
    }
}
