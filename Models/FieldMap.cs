using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class FieldMap
    {
        public int OID { get; set; }
        public Nullable<int> LoadOrderOverall { get; set; }
        public Nullable<int> LoadOrderForThisBO { get; set; }
        public string ExcelTabName { get; set; }
        public string ExcelColumnName { get; set; }
        public Nullable<int> ExcelColumnPosition { get; set; }
        public Nullable<int> BOField { get; set; }
        public Nullable<System.Guid> InputFile { get; set; }
        public Nullable<System.Guid> DataLoadMap { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual DataLoadMap DataLoadMap1 { get; set; }
        public virtual ObjectField ObjectField { get; set; }
        public virtual FileData FileData { get; set; }
    }
}
