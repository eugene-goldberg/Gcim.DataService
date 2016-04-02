using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ReportDataV2
    {
        public System.Guid Oid { get; set; }
        public string ObjectTypeName { get; set; }
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public string ParametersObjectTypeName { get; set; }
        public Nullable<bool> IsInplaceReport { get; set; }
        public string PredefinedReportType { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    }
}
