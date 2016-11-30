using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ChangeRecord
    {
        public int ID { get; set; }
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string ProposedChangeContent { get; set; }
    }
}
