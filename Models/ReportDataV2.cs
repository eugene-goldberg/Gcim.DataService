using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ReportDataV2
    {
        public int ID { get; set; }
        public string DataTypeName { get; set; }
        public bool IsInplaceReport { get; set; }
        public string PredefinedReportTypeName { get; set; }
        public byte[] Content { get; set; }
        public string DisplayName { get; set; }
        public string ParametersObjectTypeName { get; set; }
    }
}
