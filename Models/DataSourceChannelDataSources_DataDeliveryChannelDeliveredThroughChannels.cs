using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels
    {
        public Nullable<System.Guid> DeliveredThroughChannels { get; set; }
        public Nullable<System.Guid> ChannelDataSources { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataDeliveryChannel DataDeliveryChannel { get; set; }
        public virtual DataSource DataSource { get; set; }
    }
}
