using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class Tool
    {
        public Tool()
        {
            this.Accounts = new List<Account>();
        }

        public int ID { get; set; }
        public int ToolID { get; set; }
        public string ToolCategoryName { get; set; }
        public string ToolInstanceName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
