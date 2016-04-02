using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools
    {
        public Nullable<System.Guid> AssociatedGambiTools { get; set; }
        public Nullable<System.Guid> AssociatedMasterData { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual GambiTool GambiTool { get; set; }
        public virtual MasterData MasterData { get; set; }
    }
}
