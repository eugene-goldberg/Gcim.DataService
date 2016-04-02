namespace SelfHostedWebApiDataService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataLoadMap
    {
        public int ID { get; set; }

        public string DataLoadMapName { get; set; }

        public string Description { get; set; }

        public string FileName { get; set; }

        public string ImportFileName { get; set; }

        public int? FieldMapsImportFile_ID { get; set; }

        public int? InputFile_ID { get; set; }

        public virtual FileData FileData { get; set; }

        public virtual FileData FileData1 { get; set; }
    }
}
