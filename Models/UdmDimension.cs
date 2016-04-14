using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class UdmDimension
    {
        public UdmDimension()
        {
            this.DataEntities = new List<DataEntity>();
            this.UdmFacts = new List<UdmFact>();
            this.UdmMeasures = new List<UdmMeasure>();
        }

        public int ID { get; set; }
        public string EntityName { get; set; }
        public string EntityAttributeName { get; set; }
        public string EntityAttributeDescription { get; set; }
        public string DataMartDatabaseName { get; set; }
        public string DimensionTableName { get; set; }
        public string DimensionColumnName { get; set; }
        public string DimensionLoadProcedure { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<UdmFact> UdmFacts { get; set; }
        public virtual ICollection<UdmMeasure> UdmMeasures { get; set; }
    }
}
