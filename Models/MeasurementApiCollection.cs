using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatAPI2.Models
{

    public class MeasurementApiCollection
    {
        public List<MeasurementApi> Measurement { get; set; }
        public byte Status { get; set; }

        public MeasurementApiCollection()
        {
            Measurement = new List<MeasurementApi>();
        }
    }

    public class MeasurementApi
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
