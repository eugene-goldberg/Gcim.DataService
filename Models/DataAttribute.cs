using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataAttribute
    {
        public DataAttribute()
        {
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataDeliveryMethods = new List<DataDeliveryMethod>();
            this.DataEntities = new List<DataEntity>();
            this.Udms = new List<Udm>();
        }

        public int ID { get; set; }
        public string AttributeNmae { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }
        public byte IsNullAllowed { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataDeliveryMethod> DataDeliveryMethods { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
    }
}
