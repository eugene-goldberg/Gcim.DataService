using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataLoadMap
    {
        public DataLoadMap()
        {
            this.FieldMaps = new List<FieldMap>();
        }

        public System.Guid Oid { get; set; }
        public string DataLoadMapName { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string ImportFileName { get; set; }
        public Nullable<System.Guid> InputFile { get; set; }
        public Nullable<System.Guid> FieldmapsImportFile { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual FileData FileData { get; set; }
        public virtual FileData FileData1 { get; set; }
        public virtual ICollection<FieldMap> FieldMaps { get; set; }
    }
}
