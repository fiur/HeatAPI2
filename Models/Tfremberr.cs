using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Tfremberr")]
    public class Tfremberr : Measurement
    {
        public Tfremberr()
        {
            Name = "Tfremberr";
            Unit = "°C";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 43009;
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 10;
        }
        public void convert()
        {
            Value = Value / Multiplier;
        }
    }
}
