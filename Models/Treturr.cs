using System;
using System.Collections.Generic;

namespace HeatAPI.Models
{
    public class Treturr : Measurement
    {
        public Treturr()
        {
            Name = "Treturr";
            Unit = "°C";
            Controllable = false;
            modBusAddress = 1;
            modBusSlaveidAddress = 40012;
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

