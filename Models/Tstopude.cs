using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Tstopude")]
    public class Tstopude : Measurement
    {
        public Tstopude()
        {
            Name = "Tstopude";
            Unit = "°C";
            Controllable = true;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 47375;
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
