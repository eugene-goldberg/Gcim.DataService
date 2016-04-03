using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class User
    {
        public User()
        {
            this.Roles = new List<Role>();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public bool ChangePasswordOnFirstLogon { get; set; }
        public string StoredPassword { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
