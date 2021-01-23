using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("alarmer")]
    public class Alarmer : Measurement
    {
        public Alarmer()
        {
            Name = "Alarmer";
            Unit = "stk";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 41000;
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 1;
        }
    }
}
