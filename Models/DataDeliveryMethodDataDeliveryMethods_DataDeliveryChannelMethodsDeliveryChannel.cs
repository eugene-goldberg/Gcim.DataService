using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel
    {
        public Nullable<System.Guid> MethodsDeliveryChannel { get; set; }
        public Nullable<System.Guid> DataDeliveryMethods { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataDeliveryChannel DataDeliveryChannel { get; set; }
        public virtual DataDeliveryMethod DataDeliveryMethod { get; set; }
    }
}
