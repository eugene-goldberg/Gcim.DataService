using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class OdsDataAttribute
    {
        public OdsDataAttribute()
        {
            this.DataEntities = new List<DataEntity>();
        }

        public int ID { get; set; }
        public string ToolInstanceName { get; set; }
        public string OdsDatabaseName { get; set; }
        public string SourceTableName { get; set; }
        public string SourceColumnName { get; set; }
        public string SourceColumnType { get; set; }
        public int SourceColumnLength { get; set; }
        public string OdsTableName { get; set; }
        public string OdsColumnName { get; set; }
        public string OdsColumnType { get; set; }
        public int OdsColumnLength { get; set; }
        public string Transformation { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
    }
}
