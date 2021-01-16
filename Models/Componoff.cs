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
            modBusAddress = 1;
            modBusSlaveidAddress = 44457;
            modBusCount = 1;
            modBusSize = 16;
            modBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            multiplier = 1;
        }
    }

}
