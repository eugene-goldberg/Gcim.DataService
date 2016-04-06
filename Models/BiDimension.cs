using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BiDimension
    {
        public BiDimension()
        {
            this.DataEntities = new List<DataEntity>();
            this.BiFacts = new List<BiFact>();
            this.BiMeasures = new List<BiMeasure>();
        }

        public int ID { get; set; }
        public string TableName { get; set; }
        public string DataMartDatabaseName { get; set; }
        public bool Conformed { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<BiFact> BiFacts { get; set; }
        public virtual ICollection<BiMeasure> BiMeasures { get; set; }
    }
}
