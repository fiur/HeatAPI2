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
            modBusAddress = 2;
            modBusSlaveidAddress = 52;
            modBusCount = 1;
            modBusSize = 32;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 10;
        }
        public void convert()
        {
            Value = Value / multiplier;
        }
    }
}
