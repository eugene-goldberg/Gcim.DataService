namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModuleInfo
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string AssemblyFileName { get; set; }

        public bool IsMain { get; set; }
    }
}
