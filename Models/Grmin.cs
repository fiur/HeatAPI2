using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Grmin")]
    public class Grmin : Measurement
    {
        public Grmin()
        {
            Name = "Grmin";
            Unit = "";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 43005;
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
