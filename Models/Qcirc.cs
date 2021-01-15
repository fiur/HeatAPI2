using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Qcirc : Measurement
    {
        public Qcirc()
        {
            Name = "Qcirc";
            Unit = "l/min";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40072;
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

