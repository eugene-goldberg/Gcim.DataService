using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryActivity
    {
        public System.Guid Oid { get; set; }
        public Nullable<System.DateTime> DateRecorded { get; set; }
        public string DataDescription { get; set; }
        public Nullable<int> Activity { get; set; }
        public string DataSource { get; set; }
        public Nullable<int> SourceDataFormat { get; set; }
        public Nullable<int> TargetDataFormat { get; set; }
        public string TargetName { get; set; }
        public string PersonPerformingActivity { get; set; }
        public Nullable<System.DateTime> ActivityStartDate { get; set; }
        public Nullable<System.DateTime> ActivityEndDate { get; set; }
        public Nullable<int> CurrentStatus { get; set; }
        public Nullable<int> NumberOfRecordsLoaded { get; set; }
        public Nullable<int> TotalNumberOfRecordsInTheTarget { get; set; }
        public string Comments { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    }
}
