using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Componoff")]
    public class Componoff : Measurement
    {
        public Componoff()
        {
            Name = "Componoff";
            Unit = "";
            Controllable = false;
            ModBusAddress = 1;
            ModBusSlaveidAddress = 44457;
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 1;
        }
    }

}
