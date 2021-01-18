using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Treturr")]
    public class Treturr : Measurement
    {
        public Treturr()
        {
            Name = "Treturr";
            Unit = "°C";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 40012;
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

