using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class HCategory
    {
        public HCategory()
        {
            this.HCategory1 = new List<HCategory>();
        }

        public System.Guid Oid { get; set; }
        public Nullable<System.Guid> Parent { get; set; }
        public string Name { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<HCategory> HCategory1 { get; set; }
        public virtual HCategory HCategory2 { get; set; }
    }
}
