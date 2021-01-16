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
            modBusAddress = 1;
            modBusSlaveidAddress = 43005;
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
