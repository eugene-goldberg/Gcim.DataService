using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Analysis
    {
        public System.Guid Oid { get; set; }
        public string DimensionPropertiesString { get; set; }
        public string Name { get; set; }
        public string Criteria { get; set; }
        public string ObjectTypeName { get; set; }
        public byte[] ChartSettingsContent { get; set; }
        public byte[] PivotGridSettingsContent { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    }
}
