using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Pprodvarme")]
    public class Pprodvarme : Measurement
    {
        public Pprodvarme()
        {
            Name = "Pprodvarme";
            Unit = "kwh";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 44308;
            ModBusCount = 1;
            ModBusSize = 32;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/uint32/";
            Multiplier = 10;
        }
        public void convert()
        {
            Value = Value / Multiplier;
        }
    }
}
