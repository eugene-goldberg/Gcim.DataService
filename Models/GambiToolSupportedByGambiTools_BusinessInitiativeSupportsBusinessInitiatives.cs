using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives
    {
        public Nullable<System.Guid> SupportsBusinessInitiatives { get; set; }
        public Nullable<System.Guid> SupportedByGambiTools { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual GambiTool GambiTool { get; set; }
    }
}
