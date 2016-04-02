using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels
    {
        public Nullable<System.Guid> DataFormatChannels { get; set; }
        public Nullable<System.Guid> ChannelDataFormats { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataDeliveryChannel DataDeliveryChannel { get; set; }
        public virtual DataFormat DataFormat { get; set; }
    }
}
