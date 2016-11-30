using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Role
    {
        public Role()
        {
            this.TypePermissionObjects = new List<TypePermissionObject>();
            this.Roles1 = new List<Role>();
            this.Roles = new List<Role>();
            this.Users = new List<User>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAdministrative { get; set; }
        public bool CanEditModel { get; set; }
        public virtual ICollection<TypePermissionObject> TypePermissionObjects { get; set; }
        public virtual ICollection<Role> Roles1 { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
