using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals
    {
        public Nullable<System.Guid> DataDeliveryChannelBusinessGoals { get; set; }
        public Nullable<System.Guid> BusinessGoalDataDeliveryChannels { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessGoal BusinessGoal { get; set; }
        public virtual DataDeliveryChannel DataDeliveryChannel { get; set; }
    }
}
