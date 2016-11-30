using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class UdmMeasure
    {
        public UdmMeasure()
        {
            this.DataEntities = new List<DataEntity>();
            this.UdmDimensions = new List<UdmDimension>();
            this.UdmFacts = new List<UdmFact>();
        }

        public int ID { get; set; }
        public string Measure { get; set; }
        public string EtlOrSsas { get; set; }
        public string SsasCalculation { get; set; }
        public string DataMartDatabaseName { get; set; }
        public string FactTableName { get; set; }
        public string DetailTableName { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<UdmDimension> UdmDimensions { get; set; }
        public virtual ICollection<UdmFact> UdmFacts { get; set; }
    }
}
