using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Tvv")]
    public class Tvv : Measurement
    {
        public Tvv()
        {
            Name = "Tvv";
            Unit = "°C";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 40013;
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

