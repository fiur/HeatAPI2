using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Ptotude")]
    public class Ptotude : Measurement
    {
        public Ptotude()
        {
            Name = "Ptotude";
            Unit = "kwh";
            Controllable = false;
            ModBusAddress = 2;
            ModBusSlaveidAddress = 52;
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
