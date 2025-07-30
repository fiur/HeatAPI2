using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeatAPI.Models
{
    [Table("Qcircradiator")]
    public class Qcircradiator : Measurement
    {
        public Qcircradiator()
        {
            Name = "Qcircradiator";
            Unit = "l/min";
            Controllable = false;
            ModBusAddress = 1;
          /*  ModBusSlaveidAddress = ""; */
            ModBusCount = 1;
            ModBusSize = 16;
            ModBusEndpoint = "http://modbusgw.local/api/RWSingle/Short/";
            Multiplier = 1;
        }
        public void Convert()
        {
            Value /= Multiplier;
        }
    }
}

