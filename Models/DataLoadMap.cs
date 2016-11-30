using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataLoadMap
    {
        public int ID { get; set; }
        public string DataLoadMapName { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string ImportFileName { get; set; }
        public Nullable<int> FieldMapsImportFile_ID { get; set; }
        public Nullable<int> InputFile_ID { get; set; }
        public virtual FileData FileData { get; set; }
        public virtual FileData FileData1 { get; set; }
    }
}
