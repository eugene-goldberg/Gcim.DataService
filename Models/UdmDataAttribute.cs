using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class UdmDataAttribute
    {
        public UdmDataAttribute()
        {
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataEntities = new List<DataEntity>();
            this.Udms = new List<Udm>();
        }

        public int ID { get; set; }
        public string EntityName { get; set; }
        public string EntityAttributeName { get; set; }
        public string EntityAttributeDescription { get; set; }
        public string DataMartDatabaseName { get; set; }
        public string DataMartTableName { get; set; }
        public string DataMartAttributeName { get; set; }
        public string OdsDatabaseName { get; set; }
        public string OdsTableName { get; set; }
        public string OdsColumnName { get; set; }
        public string BusinessRules { get; set; }
        public string LoadProgram { get; set; }
        public string ToolInstanceName { get; set; }
        public Nullable<int> UdmFact_ID { get; set; }
        public virtual UdmFact UdmFact { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
    }
}
