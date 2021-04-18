using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Vkurve")]
    public class Vkurve : Measurement
    {
        public Vkurve()
        {
            Name = "Vkurve";
            Unit = "";
            Controllable = true;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 47007;
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
