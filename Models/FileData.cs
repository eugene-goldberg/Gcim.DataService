using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class FileData
    {
        public FileData()
        {
            this.DataLoadMaps = new List<DataLoadMap>();
            this.DataLoadMaps1 = new List<DataLoadMap>();
            this.FieldMaps = new List<FieldMap>();
            this.MetricMockups = new List<MetricMockup>();
        }

        public System.Guid Oid { get; set; }
        public Nullable<int> size { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataLoadMap> DataLoadMaps { get; set; }
        public virtual ICollection<DataLoadMap> DataLoadMaps1 { get; set; }
        public virtual ICollection<FieldMap> FieldMaps { get; set; }
        public virtual ICollection<MetricMockup> MetricMockups { get; set; }
    }
}
