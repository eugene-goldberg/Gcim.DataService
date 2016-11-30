using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class UdmFact
    {
        public UdmFact()
        {
            this.DataSources = new List<DataSource>();
            this.UdmDataAttributes = new List<UdmDataAttribute>();
            this.DataEntities = new List<DataEntity>();
            this.UdmDimensions = new List<UdmDimension>();
            this.UdmMeasures = new List<UdmMeasure>();
        }

        public int ID { get; set; }
        public string EntityName { get; set; }
        public string EntityAttributeName { get; set; }
        public string EntityAttributeDescription { get; set; }
        public string DataMartDatabaseName { get; set; }
        public string FactTableName { get; set; }
        public string DimensionTableName { get; set; }
        public string DimensionColumnName { get; set; }
        public string DimensionLoadProcedure { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<UdmDataAttribute> UdmDataAttributes { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<UdmDimension> UdmDimensions { get; set; }
        public virtual ICollection<UdmMeasure> UdmMeasures { get; set; }
    }
}
