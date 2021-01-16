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
            modBusAddress = 1;
            modBusSlaveidAddress = 47007;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 1;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }
}
