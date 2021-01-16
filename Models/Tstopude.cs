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
            modBusAddress = 1;
            modBusSlaveidAddress = 47375;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }
}
