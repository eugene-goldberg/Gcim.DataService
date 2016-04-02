using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MasterDataAssociatedMasterData_EntityAssociatedEntities
    {
        public Nullable<System.Guid> AssociatedEntities { get; set; }
        public Nullable<System.Guid> AssociatedMasterData { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual MasterData MasterData { get; set; }
    }
}
