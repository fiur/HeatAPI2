using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Pude")]
    public class Pude : Measurement
    {
        public Pude()
        {
            Name = "Pude";
            Unit = "watt";
            Controllable = false;
            ModBusAddress = 2;
            ModBusSlaveidAddress = 56;
            ModBusCount = 1;
            ModBusSize = 32;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 10;
        }
        public void convert()
        {
            Value = Value / Multiplier;
        }
    }
}

