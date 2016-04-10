using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BiFact
    {
        public BiFact()
        {
            this.DataAttributes = new List<DataAttribute>();
            this.DataEntities = new List<DataEntity>();
            this.DataSources = new List<DataSource>();
            this.BiDimensions = new List<BiDimension>();
            this.BiMeasures = new List<BiMeasure>();
        }

        public int ID { get; set; }
        public string TableName { get; set; }
        public string Version { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateRecorded { get; set; }
        public virtual ICollection<DataAttribute> DataAttributes { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<BiDimension> BiDimensions { get; set; }
        public virtual ICollection<BiMeasure> BiMeasures { get; set; }
    }
}
