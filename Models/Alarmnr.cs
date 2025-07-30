using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("alarmnr")]
    public class Alarmnr : Measurement
    {
        public Alarmnr()
        {
            Name = "Alarmnr";
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
