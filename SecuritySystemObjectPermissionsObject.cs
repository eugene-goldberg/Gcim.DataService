namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SecuritySystemObjectPermissionsObject
    {
        public int ID { get; set; }

        public string Criteria { get; set; }

        public bool AllowRead { get; set; }

        public bool AllowWrite { get; set; }

        public bool AllowDelete { get; set; }

        public bool AllowNavigate { get; set; }

        public bool? EffectiveRead { get; set; }

        public bool? EffectiveWrite { get; set; }

        public bool? EffectiveDelete { get; set; }

        public bool? EffectiveNavigate { get; set; }

        public int? Owner_ID { get; set; }

        public virtual TypePermissionObject TypePermissionObject { get; set; }
    }
}
