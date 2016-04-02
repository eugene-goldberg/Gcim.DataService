using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryMethod
    {
        public DataDeliveryMethod()
        {
            this.DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel = new List<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel>();
        }

        public System.Guid Oid { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public string DataFormat { get; set; }
        public string DeliveryProtocol { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel> DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel { get; set; }
    }
}
