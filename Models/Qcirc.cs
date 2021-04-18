using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Qcirc")]
    public class Qcirc : Measurement
    {
        public Qcirc()
        {
            Name = "Qcirc";
            Unit = "l/min";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 40072;
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 10;
        }
        public void Convert()
        {
            Value /= Multiplier;
        }
    }
}

