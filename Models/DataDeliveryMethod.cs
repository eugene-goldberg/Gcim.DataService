using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryMethod
    {
        public DataDeliveryMethod()
        {
            this.DataAttributes = new List<DataAttribute>();
            this.DataSources = new List<DataSource>();
            this.DataEntities = new List<DataEntity>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DataFormat { get; set; }
        public string DeliveryProtocol { get; set; }
        public virtual ICollection<DataAttribute> DataAttributes { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
    }
}
