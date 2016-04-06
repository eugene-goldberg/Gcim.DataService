using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BiMeasure
    {
        public BiMeasure()
        {
            this.DataEntities = new List<DataEntity>();
            this.BiDimensions = new List<BiDimension>();
            this.BiFacts = new List<BiFact>();
        }

        public int ID { get; set; }
        public string Measure { get; set; }
        public string EtlOrSsas { get; set; }
        public string SsasCalculation { get; set; }
        public string DataMartDatabaseName { get; set; }
        public string FactTableName { get; set; }
        public string DetailTableName { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<BiDimension> BiDimensions { get; set; }
        public virtual ICollection<BiFact> BiFacts { get; set; }
    }
}
