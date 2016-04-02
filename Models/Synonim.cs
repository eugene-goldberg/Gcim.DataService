using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Synonim
    {
        public Synonim()
        {
            this.SynonimEntitySynonims_EntitySynonimEntities = new List<SynonimEntitySynonims_EntitySynonimEntities>();
        }

        public System.Guid Oid { get; set; }
        public string SynonimName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<SynonimEntitySynonims_EntitySynonimEntities> SynonimEntitySynonims_EntitySynonimEntities { get; set; }
    }
}
