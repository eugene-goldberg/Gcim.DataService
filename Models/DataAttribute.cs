using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataAttribute
    {
        public DataAttribute()
        {
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataEntities = new List<DataEntity>();
            this.Udms = new List<Udm>();
        }

        public int ID { get; set; }
        public string UdmDataEntityAttributeName { get; set; }
        public string SourceTableName { get; set; }
        public string SourceColumnName { get; set; }
        public int SourceColumnLength { get; set; }
        public string OdsTableName { get; set; }
        public string OdsColumnName { get; set; }
        public string OdsColumnType { get; set; }
        public int OdsColumnLength { get; set; }
        public string Transformation { get; set; }
        public string Notes { get; set; }
        public Nullable<int> BiFact_ID { get; set; }
        public virtual BiFact BiFact { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
    }
}
