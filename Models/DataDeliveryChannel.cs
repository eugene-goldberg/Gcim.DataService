using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryChannel
    {
        public DataDeliveryChannel()
        {
            this.DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals = new List<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals>();
            this.DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel = new List<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel>();
            this.DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels = new List<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels>();
            this.DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels = new List<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels>();
        }

        public System.Guid Oid { get; set; }
        public string ChannelName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals> DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals { get; set; }
        public virtual ICollection<DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel> DataDeliveryMethodDataDeliveryMethods_DataDeliveryChannelMethodsDeliveryChannel { get; set; }
        public virtual ICollection<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels> DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels { get; set; }
        public virtual ICollection<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels> DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels { get; set; }
    }
}
