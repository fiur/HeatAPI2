using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Treturradiator")]
    public class Treturradiator : Measurement
    {
        public Treturradiator()
        {
            Name = "Treturradiator";
            Unit = "°C";
            Controllable = false;
            ModBusAddress = 1;
           /* ModBusSlaveidAddress = ""; */
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 1;
        }
        public void convert()
        {
            Value = Value / Multiplier;
        }
    }
}
