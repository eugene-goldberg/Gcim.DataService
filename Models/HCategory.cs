using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class HCategory
    {
        public HCategory()
        {
            this.HCategories1 = new List<HCategory>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Parent_ID { get; set; }
        public virtual ICollection<HCategory> HCategories1 { get; set; }
        public virtual HCategory HCategory1 { get; set; }
    }
}
