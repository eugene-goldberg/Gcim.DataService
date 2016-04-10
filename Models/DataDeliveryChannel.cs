using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryChannel
    {
        public DataDeliveryChannel()
        {
            this.DataSources = new List<DataSource>();
            this.DataEntities = new List<DataEntity>();
        }

        public int ID { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceTableName { get; set; }
        public string SourceQuery { get; set; }
        public string OdsDatabaseName { get; set; }
        public string OdsTableName { get; set; }
        public string OdsProcedure { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
    }
}
