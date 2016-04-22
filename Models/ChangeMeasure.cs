using System;
using System.Collections.Generic;

namespace CommonDataService.Models
{
    public partial class ChangeMeasure
    {
        public int ID { get; set; }
        public string AccountID { get; set; }
        public string MeasureName { get; set; }
        public int Value { get; set; }
        public string Justification { get; set; }
    }
}
