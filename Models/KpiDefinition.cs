using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class KpiDefinition
    {
        public KpiDefinition()
        {
            this.KpiInstances = new List<KpiInstance>();
        }

        public System.Guid Oid { get; set; }
        public string TargetObjectType { get; set; }
        public Nullable<System.DateTime> Changed { get; set; }
        public Nullable<System.Guid> KpiInstance { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Criteria { get; set; }
        public string Expression { get; set; }
        public Nullable<double> GreenZone { get; set; }
        public Nullable<double> RedZone { get; set; }
        public string Range { get; set; }
        public Nullable<bool> Compare { get; set; }
        public string RangeToCompare { get; set; }
        public Nullable<int> MeasurementFrequency { get; set; }
        public Nullable<int> MeasurementMode { get; set; }
        public Nullable<int> Direction { get; set; }
        public Nullable<System.DateTime> ChangedOn { get; set; }
        public string SuppressedSeries { get; set; }
        public Nullable<bool> EnableCustomizeRepresentation { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual KpiInstance KpiInstance1 { get; set; }
        public virtual ICollection<KpiInstance> KpiInstances { get; set; }
    }
}
