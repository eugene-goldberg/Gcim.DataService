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
        }

        public int ID { get; set; }
        public int Size { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public virtual ICollection<DataLoadMap> DataLoadMaps { get; set; }
        public virtual ICollection<DataLoadMap> DataLoadMaps1 { get; set; }
    }
}
