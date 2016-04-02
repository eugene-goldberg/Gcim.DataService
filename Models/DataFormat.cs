using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataFormat
    {
        public DataFormat()
        {
            this.DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels = new List<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels>();
        }

        public System.Guid Oid { get; set; }
        public string FormatName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels> DataFormatChannelDataFormats_DataDeliveryChannelDataFormatChannels { get; set; }
    }
}
